using ND.MCJ.AOP.Logging;
using ND.MCJ.Framework;
using ND.MCJ.Model;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ND.MCJ.AOP.Security.WebApiFilter
{
    public class Authorization : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var headers = actionContext.Request.Headers;
            var parameters = RequestHelper.Parameters;
            if (!parameters.AllKeys.Contains("PlatformId")) { throw new ArgumentException("平台参数错误"); }

            #region 验证数据签名
            var platformId = int.Parse(parameters["PlatformId"]);
            if (platformId != (int)Platform.HTML5)
            {
                if (!Signature.VerifySign(RequestHelper.Parameters))
                {
                    var response = new ResponseModel { Code = HttpStatusCode.BadRequest, Message = "签名不正确" };
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NonAuthoritativeInformation, response);
                    return;
                }
            }
            #endregion

            #region 认证授权
            if (actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any()) { return; }
            if (headers.Authorization == null) { HandleUnauthorizedRequest(actionContext); return; }
            if (String.IsNullOrWhiteSpace(headers.Authorization.Parameter))
            { HandleUnauthorizedRequest(actionContext); return; }
            if (!WebApiAuthorize.VarifyToken(headers.Authorization.Parameter))
            { HandleUnauthorizedRequest(actionContext); return; }
            IsAuthorized(actionContext);
            #endregion
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var challengeMessage = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            challengeMessage.Headers.Add("Authenticate", "basic");
            var actionName = actionContext.ActionDescriptor.ActionName;
            var controllerName = actionContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            Log.Service(new Exception("认证不通过"), String.Format("/{0}/{1}", controllerName, actionName));
            var response = new ResponseModel { Code = HttpStatusCode.Forbidden, Message = "认证不通过" };
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, response);
            return;
            // throw new HttpResponseException(challengeMessage);
        }
    }


}
