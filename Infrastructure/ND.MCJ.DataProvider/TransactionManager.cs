using System;
using System.Transactions;

namespace ND.MCJ.DataContext
{
    public class TransactionManager
    {
        private static readonly TransactionOptions tranOption =
            new TransactionOptions { Timeout = new TimeSpan(0, 1, 0), IsolationLevel = IsolationLevel.ReadCommitted };
        public static TransactionScope BeginTransactionScope()
        {
            return new TransactionScope(TransactionScopeOption.Required, tranOption);
        }
        public static TransactionScope BeginTransactionScope(TransactionScopeOption scopeOption)
        {
            return new TransactionScope(scopeOption, tranOption);
        }
    }
}
