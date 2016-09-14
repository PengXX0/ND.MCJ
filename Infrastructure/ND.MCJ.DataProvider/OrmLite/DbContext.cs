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
        protected static OrmLiteConnectionFactory _db;
        private static String DefaultConnection = String.Empty;
        private static readonly ConnectionStringSettingsCollection SqlConnections = ConfigurationManager.ConnectionStrings;
        private static Dictionary<String, OrmLiteConnectionFactory> dicConnections
        {
            get
            {
                if (OrmLiteConnectionFactory.NamedConnections.Count > 0)
                { return OrmLiteConnectionFactory.NamedConnections; }
                OrmLiteConfig.DialectProvider = SqlServerDialect.Provider;
                foreach (ConnectionStringSettings item in SqlConnections)
                {
                    if (SqlConnections.IndexOf(item) == 0) { DefaultConnection = item.Name; }
                    OrmLiteConnectionFactory.NamedConnections.Add(item.Name, new OrmLiteConnectionFactory(item.ConnectionString));
                }
                return OrmLiteConnectionFactory.NamedConnections;
            }
        }
        protected DbContext(string nameOrConnectionString)
        {
            _db = dicConnections.TryGetValue(nameOrConnectionString, out _db) ?
                _db : new OrmLiteConnectionFactory(nameOrConnectionString);
        }

        protected DbContext()
        {
            if (dicConnections.Count == 0)
            { throw new Exception("数据库连接字符串配置错误！"); }
            _db = dicConnections[DefaultConnection];
        }

        protected static void Run(Action<IDbConnection> action)
        {
            _db.Run(action);
        }

        protected static T Run<T>(Func<IDbConnection, T> func)
        {
            return _db.Run(func);
        }
    }
}
