using System;
using System.Transactions;
using System.Web.Mvc;

namespace ND.MCJ.AOP.Security.MvcFilter
{
    public class TransactionAttribute : ActionFilterAttribute
    {
        private TransactionScope Transaction { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Transaction = AOP.Transaction.TransactionManager.BeginTransactionScope();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null) { Transaction.Dispose(); return; }
            Transaction.Complete(); Transaction.Dispose();
        }
    }
}
