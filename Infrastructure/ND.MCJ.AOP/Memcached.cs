using System;
using System.Net;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using ND.MCJ.Framework;

namespace ND.MCJ.AOP
{
    public static class Memcached
    {
        private static MemcachedClient _mClient;

        /// <summary>
        /// 初始化Memcached
        /// </summary>
        public static void Initialize(string filePath)
        {
            var config = (IMemcachedClientConfiguration)Configuration.Config(filePath).GetSection("enyim.com/memcached");
            _mClient = new MemcachedClient(config);
        }

        public static bool Set(string key, object value, TimeSpan expirseIn)
        {
            if (value == null) { return false; }
            return _mClient.Store(StoreMode.Set, key, value, expirseIn);
        }

        public static bool Set(string key, object value, DateTime expirseIn)
        {
            if (value == null) { return false; }
            return _mClient.Store(StoreMode.Set, key, value, expirseIn);
        }

        public static T Get<T>(string key)
        {
            return _mClient.Get<T>(key);
        }

        public static bool Remove(string key)
        {
            return _mClient.Remove(key);
        }

        public static void RemoveAll()
        {
            _mClient.FlushAll();
        }
    }
}
