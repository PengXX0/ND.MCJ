using ND.MCJ.AOP.Caching;
using ND.MCJ.AOP.Logging;
using ND.MCJ.IOC;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using ND.MCJ.Wechat;

namespace ND.MCJ.AdminWeb
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
            Logger.Start(config["NLogConfig"]);
            Memcached.Start(config["MemcachedConfig"]);
            WechatMain.Start(config["WechatConfig"]);
            MvcHandler.DisableMvcResponseHeader = true;
            //SqlConnectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }
    }
}
