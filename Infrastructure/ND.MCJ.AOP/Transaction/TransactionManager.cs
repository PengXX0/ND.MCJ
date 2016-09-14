using System;
using System.Transactions;

namespace ND.MCJ.AOP.Transaction
{
    public class TransactionManager
    {
        private static readonly TransactionOptions TranOption =
            new TransactionOptions { Timeout = new TimeSpan(0, 1, 0), IsolationLevel = IsolationLevel.ReadCommitted };
        public static TransactionScope BeginTransactionScope()
        {
            return new TransactionScope(TransactionScopeOption.Required, TranOption);
        }
        public static TransactionScope BeginTransactionScope(TransactionScopeOption scopeOption)
        {
            return new TransactionScope(scopeOption, TranOption);
        }
    }
}
