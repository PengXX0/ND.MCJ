using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using ND.MCJ.AOP.Caching;

namespace ND.MCJ.AOP.Tests
{
    [TestClass]
    public class MemCacheTest
    {
        [TestMethod]
        public void MemCache()
        {
            Memcached.Start(ConfigurationManager.AppSettings["MemcachedConfig"]);
            var result = Memcached.Set("ND.MCJ_TEST", "dsadfsafsaf", new TimeSpan(1, 1, 1));
            Assert.IsTrue(result);
            var str = Memcached.Get<String>("ND.MCJ_TEST");
            Assert.IsTrue(str == "dsadfsafsaf");
            result = Memcached.Remove("ND.MCJ_TEST");
            Assert.IsTrue(result);

            var t = DateTime.Now.AddDays(1).Date.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(t);
            Assert.IsTrue(t == "2016-06-22 00:00:00");
        }

        [TestMethod]
        public void MemoryCache()
        {
            var memory = new MemoryCache();
            var result = memory.Set("ND.MCJ_TEST", "dsadfsafsaf", new TimeSpan(1, 1, 1));
            Assert.IsTrue(result);

            var m2 = new MemoryCache();
            var str = m2.Get<String>("ND.MCJ_TEST");
            Assert.IsTrue(str == "dsadfsafsaf");
            result = memory.Remove("ND.MCJ_TEST");
            Assert.IsTrue(result);
            var obj = memory.Get<String>("ND.MCJ_TEST");
            Assert.IsNull(obj);
        }
    }
}
