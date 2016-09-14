using ND.MCJ.AOP.Caching;
using ND.MCJ.AOP.Logging;
using ND.MCJ.IOC;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using ND.MCJ.Wechat;
using ND.MCJ.Tenpay;

namespace NC.MCJ.WebApi
{
    /// <summary>
    /// 启动引导各种初始化
    /// </summary>
    public static class Bootstrapper
    {
        public static void Register(NameValueCollection config)
        {
            AutofacResolver.Register();
            MvcHandler.DisableMvcResponseHeader = true;
            Logger.Start(config["NLogConfig"]);
            Memcached.Start(config["MemcachedConfig"]);
            WechatMain.Start(config["TenpayConfig"]);
            TenpayMain.Start(config["TenpayConfig"]);
        }
    }
}
