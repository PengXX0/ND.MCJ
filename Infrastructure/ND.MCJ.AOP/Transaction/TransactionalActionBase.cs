using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ND.MCJ.AOP.Transaction
{
    public class TransactionalActionBaseAttribute : ActionFilterAttribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class HandleTransactionManuallyAttribute : TransactionalActionBaseAttribute
    {
    }
}
