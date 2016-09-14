using System;
using System.Transactions;
using System.Web.Mvc;
using ActionFilterAttribute = System.Web.Http.Filters.ActionFilterAttribute;

namespace ND.MCJ.AOP.Security.WebApiFilter
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TransactionAttribute : ActionFilterAttribute, IActionFilter
    {
        private TransactionScope Transaction { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Transaction = AOP.Transaction.TransactionManager.BeginTransactionScope();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null) return;
            Transaction.Complete(); Transaction.Dispose();
        }
    }
}
