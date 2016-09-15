using NC.MCJ.WebApi.Areas.Help.Models;
using ND.MCJ.AOP.Logging;
using ND.MCJ.AOP.Security;
using ND.MCJ.Framework;
using NLog.Layouts;
using NLog.Targets;
using ServiceStack.Text;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace NC.MCJ.WebApi.Areas.Help.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class DevController : Controller
    {
        #region ��������
        public ActionResult Docs()
        {
            var ip = RequestHelper.RemoteIP;
            //���ƿ����ĵ�ֻ���ھ������в鿴
            if (NetworkUtility.GetIpType(ip) != NetworkUtility.NetType.LAN) { return Content("ILLEGAL REQUEST"); }
            return View();
        }

        public ActionResult Debug(DevModel request)
        {
            if (!string.IsNullOrEmpty(request.Parma)) { request.Parma = request.Parma.Replace('|', '&'); }
            if (HttpContext.Request.IsAjaxRequest()) { return Json(HttpRequest(request), JsonRequestBehavior.AllowGet); }
            return View(HttpRequest(request));
        }
        #endregion

        #region �鿴��־
        /// <summary>
        /// �鿴��־
        /// </summary>
        /// <param name="token">�鿴log����֤����</param>
        /// <param name="type">0��������в鿴  1������־�ļ�</param>
        /// <param name="fileName">�ļ��� </param>
        /// <returns></returns>
        public ActionResult Logs(string token = "", int type = 0, string fileName = null)
        {
            if (token != "1f7907aa0ddfe9eddb758efd6a9d1b17c0c4d419727ce91146523b5cbf1277ed") { return Content("ILLEGAL REQUEST"); }
            fileName = fileName ?? DateTime.Now.ToString("yyyy-MM-dd");
            var filePath = ((SimpleLayout)((FileTarget)Logger.LogConfig.FindTargetByName("GlobalLog")).FileName).Text.Replace("${shortdate}", fileName);
            return LoadLogs(filePath, type, fileName);
        }

        public ActionResult AppLogs(int type = 0, string fileName = null, int platform = 2)
        {
            var logName = "Android";
            switch (platform)
            {
                case 1:
                    logName = "Android";
                    break;
                case 2:
                    logName = "IOS";
                    break;
            }
            fileName = fileName ?? DateTime.Now.ToString("yyyy-MM-dd");
            var filePath = ((SimpleLayout)((FileTarget)Logger.LogConfig.FindTargetByName(logName)).FileName).Text.Replace("${shortdate}", fileName);
            return LoadLogs(filePath, type, fileName);
        }
        #endregion

        #region ˽�з���
        /// <summary>
        /// ������־
        /// </summary>
        /// <param name="filePath">�ļ�·��</param>
        /// <param name="type">0�����������ʾ   1����</param>
        /// <param name="fileName">��־�ļ���</param>
        /// <returns></returns>
        private ActionResult LoadLogs(string filePath, int type, string fileName)
        {
            if (!System.IO.File.Exists(filePath)) { return Content("�ļ�������"); }
            if (type == 0)
            {
                var stream = new FileStream(filePath, FileMode.Open);
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length); stream.Dispose();
                return Content(Encoding.Default.GetString(bytes), "text/plain");
            }
            Response.ClearContent(); Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + "_new.txt");
            Response.TransmitFile(filePath); Response.Flush(); Response.End();
            return new EmptyResult();
        }

        private static DevModel HttpRequest(DevModel request)
        {
            request.Method = request.Method ?? HttpMethod.Get.ToString();
            var parma = request.Parma;
            if (!string.IsNullOrWhiteSpace(request.Parma))
            { if (!parma.Contains("Platform=Id")) { parma = request.Parma.TrimEnd('&') + "&PlatformId=" + (request.PlatformId ?? 1); } }
            else { parma = "PlatformId=" + (request.PlatformId ?? 1); }
            var dic = parma.Split('&').Where(item => !string.IsNullOrEmpty(item)).ToDictionary(item => item.Split('=')[0], item => item.Split('=')[1]);
            var sign = Signature.MakeSign(dic);
            var response = new DevModel
            {
                Url = request.Url,
                Method = request.Method,
                Parma = request.Parma,
                PlatformId = request.PlatformId,
                Sign = sign
            };
            var formData = (parma.TrimEnd('&') + "&Sign=" + sign);
            var nc = new NameValueCollection { { "Authorization", sign } };

            try
            {
                switch (request.Method.ToUpper())
                {
                    case "GET":
                        request.Url = (request.Url + "?" + formData);
                        response.Response = request.Url.GetJsonFromUrl(s => s.Headers.Add(nc));
                        break;
                    case "POST":
                        response.Response = request.Url.PostToUrl(formData, WebRequestExtensions.Json, s => s.Headers.Add(nc));
                        break;
                    case "PUT":
                        response.Response = request.Url.PutToUrl(formData, WebRequestExtensions.Json, s => s.Headers.Add(nc));
                        break;
                    case "DELETE":
                        request.Url = (request.Url + "?" + formData);
                        response.Response = request.Url.DeleteFromUrl(WebRequestExtensions.Json, s => s.Headers.Add(nc));
                        break;
                }
            }
            catch (Exception ex)
            {
                response.Response = ex.Message;
            }
            return response;
        }
        #endregion
    }
}