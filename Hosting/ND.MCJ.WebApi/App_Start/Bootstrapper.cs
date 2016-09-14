using ND.MCJ.AOP;
using ND.MCJ.AOP.Logging;
using ND.MCJ.IOC;
using System.Collections.Specialized;

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
            Logger.Initialize(config["NLogConfig"]);
            Memcached.Initialize(config["MemcachedConfig"]);
        }
    }
}