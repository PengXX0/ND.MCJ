using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace ND.MCJ.AOP.Tests
{
    [TestClass]
    public class MemCacheTest
    {
        [TestMethod]
        public void MemCache()
        {
            Memcached.Initialize(ConfigurationManager.AppSettings["MemcachedConfig"]);
            var result = Memcached.Set("ND.MCJ_TEST", "dsadfsafsaf", new TimeSpan(1, 1, 1));
            Assert.IsTrue(result);
            var str = Memcached.Get<String>("ND.MCJ_TEST");
            Assert.IsTrue(str == "dsadfsafsaf");
            result = Memcached.Remove("ND.MCJ_TEST");
            Assert.IsTrue(result);

            var t = DateTime.Now.AddDays(1).Date.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(t);
            Assert.IsTrue(t == "2016-05-19 00:00:00");
        }
    }
}
