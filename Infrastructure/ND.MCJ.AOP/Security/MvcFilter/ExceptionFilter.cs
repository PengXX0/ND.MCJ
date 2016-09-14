using System;
using System.Net;
using System.Web.Mvc;
using ND.MCJ.AOP.Logging;
using ND.MCJ.Model;

namespace ND.MCJ.AOP.Security.MvcFilter
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter, IActionFilter
    {
        public String Caption { get; set; }
        public bool? IsService { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ActionName = filterContext.ActionDescriptor.ActionName;
            ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
        }

        public void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            var jsonResult = new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = new ResponseModel { Code = HttpStatusCode.BadRequest, Message = ex.Message }
            };
            var viewResult = new ViewResult { ViewName = "Error", ViewData = filterContext.Controller.ViewData, };
            filterContext.Result = (IsService ?? true) ? (ActionResult)jsonResult : viewResult;
            if ((IsService ?? true))
            { LogType.LogService(ex, Caption ?? String.Format("/{0}/{1}", ControllerName, ActionName)); }
            else
            { LogType.LogWebPage(ex, Caption ?? String.Format("/{0}/{1}", ControllerName, ActionName)); }
            filterContext.ExceptionHandled = true;
        }
        public void OnActionExecuted(ActionExecutedContext filterContext) { }
    }
}
