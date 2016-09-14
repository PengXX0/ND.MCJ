using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ND.MCJ.AOP.Caching;
using Newtonsoft.Json.Linq;
using ServiceStack.Text;
using Configuration = ND.MCJ.Framework.Configuration;

namespace ND.MCJ.Wechat
{
    public class WechatMain
    {
        public static KeyValueConfigurationCollection Config { get; set; }
        public static void Start(string filePath) { Config = Configuration.GetCollection(filePath); }

        public const String TokenCacheKey = "MCJ_ManageAccessToken";
        public static String AppId { get { return Config["WechatAuthAppId"].Value; } }
        public static String AppSecret { get { return Config["WechatAuthAppSecret"].Value; } }

        public static String AccessToken{
            get { var token = Memcached.Get<String>(TokenCacheKey); return String.IsNullOrWhiteSpace(token) ? GetToken() : token; }
        }

        private static String GetToken(){
            const string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
            var obj = JObject.Parse(string.Format(url, AppId, AppSecret).GetJsonFromUrl());
            Memcached.Set(TokenCacheKey, obj["access_token"], new TimeSpan(0, 0, 0, obj["expires_in"].ToObject<int>() - 60));
            return obj["access_token"].ToString();
        }
    }
}
