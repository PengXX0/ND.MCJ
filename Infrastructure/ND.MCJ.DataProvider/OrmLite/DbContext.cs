using System;
using System.Configuration;
using System.Data;
using System.Transactions;
using ServiceStack.OrmLite;
using ServiceStack.Text;
using System.Text;
using ND.MCJ.Model;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections;

namespace ND.MCJ.DataProvider.OrmLite
{
    public class DbContext
    {
        protected static OrmLiteConnectionFactory Db;
        private static String _defaultConnection = String.Empty;
        private static readonly ConnectionStringSettingsCollection SqlConnections = ConfigurationManager.ConnectionStrings;
        private static Dictionary<String, OrmLiteConnectionFactory> DicConnections
        {
            get
            {
                if (OrmLiteConnectionFactory.NamedConnections.Count > 0)
                { return OrmLiteConnectionFactory.NamedConnections; }
                OrmLiteConfig.DialectProvider = SqlServerDialect.Provider;
                foreach (ConnectionStringSettings item in SqlConnections)
                {
                    if (SqlConnections.IndexOf(item) == 0) { _defaultConnection = item.Name; }
                    OrmLiteConnectionFactory.NamedConnections.Add(item.Name, new OrmLiteConnectionFactory(item.ConnectionString));
                }
                return OrmLiteConnectionFactory.NamedConnections;
            }
        }
        protected DbContext(string nameOrConnectionString)
        {
            Db = DicConnections.TryGetValue(nameOrConnectionString, out Db) ?
                Db : new OrmLiteConnectionFactory(nameOrConnectionString);
        }

        protected DbContext()
        {
            if (DicConnections.Count == 0)
            { throw new Exception("数据库连接字符串配置错误！"); }
            Db = DicConnections[_defaultConnection];
        }

        protected static void Run(Action<IDbConnection> action)
        {
            Db.Run(action);
        }

        protected static T Run<T>(Func<IDbConnection, T> func)
        {
            return Db.Run(func);
        }
    }
}
