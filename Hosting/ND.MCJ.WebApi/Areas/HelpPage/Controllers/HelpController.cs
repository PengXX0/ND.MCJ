using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
using NC.MCJ.WebApi.Areas.HelpPage.Models;
using ND.MCJ.AOP;
using ND.MCJ.AOP.Log;
using ND.MCJ.AOP.Security;
using ND.MCJ.Framework;
using NLog.Layouts;
using NLog.Targets;
using ServiceStack.Text;

namespace NC.MCJ.WebApi.Areas.HelpPage.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        //public HelpController() : this(GlobalConfiguration.Configuration) { }
        //public HelpController(HttpConfiguration config) { Configuration = config; }
        //public HttpConfiguration Configuration { get; private set; }

        #region 开发调试
        public ActionResult Docs()
        {
            //限制开发文档只能在局域网中查看
            if (NetworkUtility.GetIpType(RequestHelper.RemoteIP) != NetworkUtility.NetType.LAN) { return Content("ILLEGAL REQUEST"); }
            return View();
        }

        public ActionResult Debug(DevModel request)
        {
            if (!string.IsNullOrEmpty(request.Parma)) { request.Parma = request.Parma.Replace('|', '&'); }
            if (HttpContext.Request.IsAjaxRequest()) { return Json(HttpRequest(request), JsonRequestBehavior.AllowGet); }
            return View(HttpRequest(request));
        }
        #endregion

        #region 查看日志
        /// <summary>
        /// 查看日志
        /// </summary>
        /// <param name="token">查看log的认证令牌</param>
        /// <param name="type">0在浏览器中查看  1下载日志文件</param>
        /// <param name="fileName">文件名 </param>
        /// <returns></returns>
        public ActionResult Logs(string token = "", int type = 0, string fileName = null)
        {
            if (token != "1f7907aa0ddfe9eddb758efd6a9d1b17c0c4d419727ce91146523b5cbf1277ed") { return Content("ILLEGAL REQUEST"); }
            fileName = fileName ?? DateTime.Now.ToString("yyyy-MM-dd");
            var filePath = ((SimpleLayout)((FileTarget)Logging.LogConfig.FindTargetByName("GlobalLog")).FileName).Text.Replace("${shortdate}", fileName);
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
            var filePath = ((SimpleLayout)((FileTarget)Logging.LogConfig.FindTargetByName(logName)).FileName).Text.Replace("${shortdate}", fileName);
            return LoadLogs(filePath, type, fileName);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 加载日志
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="type">0在浏览器中显示   1下载</param>
        /// <param name="fileName">日志文件名</param>
        /// <returns></returns>
        private ActionResult LoadLogs(string filePath, int type, string fileName)
        {
            if (!System.IO.File.Exists(filePath)) { return Content("文件不存在"); }
            if (type == 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    var bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, bytes.Length);
                    return Content(Encoding.Default.GetString(bytes), "text/plain");
                }
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
            { if (!parma.Contains("Platform=")) { parma = request.Parma.TrimEnd('&') + "&Platform=" + (request.Platform ?? 1); } }
            else { parma = "Platform=" + (request.Platform ?? 1); }
            var dic = parma.Split('&').Where(item => !string.IsNullOrEmpty(item)).ToDictionary(item => item.Split('=')[0], item => item.Split('=')[1]);
            var sign = Signature.MakeSign(dic);
            var response = new DevModel
            {
                Url = request.Url,
                Method = request.Method,
                Parma = request.Parma,
                Platform = request.Platform,
                Sign = sign
            };
            var formData = (parma.TrimEnd('&') + "&Sign=" + sign);
            try
            {
                switch (request.Method.ToUpper())
                {
                    case "GET":
                        request.Url = (request.Url + "?" + formData);
                        response.Response = request.Url.GetJsonFromUrl();
                        break;
                    case "POST":
                        response.Response = request.Url.PostToUrl(formData);
                        break;
                    case "PUT":
                        response.Response = request.Url.PutToUrl(formData);
                        break;
                    case "DELETE":
                        request.Url = (request.Url + "?" + formData);
                        response.Response = request.Url.DeleteFromUrl();
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