using ND.MCJ.AOP.Logging;
using ND.MCJ.IOC;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;

namespace ND.MCJ.AOP
{
    /// <summary>
    /// 启动引导各种初始化
    /// </summary>
    public static class Bootstrapper
    {
        public static String SqlConnectionString { get; set; }
        public static void Register(NameValueCollection config)
        {
            AutofacResolver.Register();
            Logger.Initialize(config["NLogConfig"]);
            Memcached.Initialize(config["MemcachedConfig"]);
            MvcHandler.DisableMvcResponseHeader = true;
            //SqlConnectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }
    }
}
