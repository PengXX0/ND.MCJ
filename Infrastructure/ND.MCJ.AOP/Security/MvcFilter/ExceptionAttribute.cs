using System;
using System.Net;
using System.Linq;
using System.Transactions;
using System.Web.Mvc;
using ND.MCJ.AOP.Logging;
using ND.MCJ.Model;
using ND.MCJ.Framework;
using ND.MCJ.Framework.Converter;

namespace ND.MCJ.AOP.Security.MvcFilter
{
    public class ExceptionAttribute : FilterAttribute, IExceptionFilter, IActionFilter
    {
        /// <summary>
        /// 标题
        /// </summary>
        private String Caption { get; set; }
        /// <summary>
        /// 是服务型接口则返回Json，否则返回视图，（默认为服务型接口）
        /// </summary>
        private bool? IsService { get; set; }
        /// <summary>
        /// 是否启用事物（默认不启用）
        /// </summary>
        private bool? IsTransaction { get; set; }
        private string ActionName { get; set; }
        private string ControllerName { get; set; }
        private TransactionScope Transaction { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Controller.ViewData.ModelState
            if (!filterContext.Controller.ViewData.ModelState.IsValid && (IsService ?? true))
            {
                var jsonResult = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new ResponseModel
                    {
                        Code = HttpStatusCode.BadRequest,
                        Message = filterContext.Controller.ViewData.ModelState.FirstError()
                    }
                };
            }
            ActionName = filterContext.ActionDescriptor.ActionName;
            ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (IsTransaction ?? false) { Transaction = AOP.Transaction.TransactionManager.BeginTransactionScope(); }

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
            { Log.Service(ex, Caption ?? String.Format("/{0}/{1}", ControllerName, ActionName)); }
            else
            { Log.WebPage(ex, Caption ?? String.Format("/{0}/{1}", ControllerName, ActionName)); }
            filterContext.ExceptionHandled = true;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null) { Transaction.Dispose(); return; }
            if (!(IsTransaction ?? false)) return;
            Transaction.Complete(); Transaction.Dispose();
        }
    }
}
