//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Web.Mvc;

//namespace ND.MCJ.AOP.Transaction
//{
//    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
//    public class TransactionAttribute : ActionFilterAttribute
//    {
//        private IDbContext _dbContext;
//        private bool _delegateTransactionSupport;
//        public IDbContext DbContext
//        {
//            get
//            {
//                if (_dbContext == null) _dbContext = SmartServiceLocator<IDbContext>.GetService();

//                return _dbContext;
//            }
//        }


//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            _delegateTransactionSupport = ShouldDelegateTransactionSupport(filterContext);

//            if (_delegateTransactionSupport) return;

//            DbContext.BeginTransaction();
//        }

//        public override void OnActionExecuted(ActionExecutedContext filterContext)
//        {
//            if (_delegateTransactionSupport) return;

//            if (DbContext.IsActive)
//            {
//                if (filterContext.Exception == null)
//                {
//                    DbContext.CommitTransaction();
//                }
//                else
//                {
//                    DbContext.RollbackTransaction();
//                }
//            }
//        }

//        private static bool ShouldDelegateTransactionSupport(ActionExecutingContext context)
//        {
//            var attrs = context.ActionDescriptor.GetCustomAttributes(typeof(TransactionalActionBaseAttribute), false);

//            return attrs.Length > 0;
//        }
//    }
//}
