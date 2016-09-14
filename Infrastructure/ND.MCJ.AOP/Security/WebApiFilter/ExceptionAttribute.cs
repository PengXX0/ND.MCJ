using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Threading.Tasks;
using ND.MCJ.AOP.Logging;
using ND.MCJ.Model;

namespace ND.MCJ.AOP.Security.WebApiFilter
{
    public class ExceptionAttribute : ExceptionFilterAttribute
    {
        public String Caption { get; set; }
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            var controllerName = actionExecutedContext.ActionContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            Log.Service(actionExecutedContext.Exception, Caption ?? String.Format("/{0}/{1}", controllerName, actionName));
            actionExecutedContext.Response =
                    actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK,
                        new ResponseModel { Code = HttpStatusCode.BadRequest, Message = actionExecutedContext.Exception.Message });

        }
    }
}
