using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ND.MCJ.AOP.Caching;
using Newtonsoft.Json.Linq;
using ServiceStack.Text;
using Configuration = ND.MCJ.Framework.Configuration;

namespace ND.MCJ.Tenpay
{
    public class TenpayMain
    {
        public static KeyValueConfigurationCollection Config { get; set; }
        public static void Start(string filePath) { Config = Configuration.GetCollection(filePath); }

        /// <summary>
        /// 缓存微信AccessToken的Key
        /// </summary>
        public const String TokenCacheKey = "MCJ_ManageAccessToken";
        /// <summary>
        /// 微信的AppId
        /// </summary>
        public static String AppId { get { return Config["WechatAuthAppId"].Value; } }
        /// <summary>
        /// 微信公众账号的APPSECRET
        /// </summary>
        public static String AppSecret { get { return Config["WechatAuthAppSecret"].Value; } }
        /// <summary>
        /// 微信支付密钥
        /// </summary>
        public static String SecretKey { get { return Config["WechatSecretKey"].Value; } }
        /// <summary>
        /// 微信商户号
        /// </summary>
        public static String MchId { get { return Config["WechatMchId"].Value; } }
        /// <summary>
        /// 微信跳转地址
        /// </summary>
        public static String RedirectUrl { get { return Config["WechatAuthCodeRedirectUrl"].Value; } }
        /// <summary>
        /// 微信支付证书路径
        /// </summary>
        public static String SSLCertPath { get { return Config["WechatSSLCertPath"].Value; } }
        /// <summary>
        /// 微信支付证书密码
        /// </summary>
        public static String SSLCertPassword { get { return Config["WechatSSLCertPassword"].Value; } }
        /// <summary>
        /// 微信支付回调地址
        /// </summary>
        public static String NotifyUrl { get { return Config["WechatNotifyUrl"].Value; } }
        /// <summary>
        /// 微信支付测速上报 0、不需要上报   1、上报
        /// </summary>
        public static int ReportLevel { get { return Convert.ToInt32(Config["WechatReportLevel"].Value); } }


        public static String AccessToken
        {
            get { var token = Memcached.Get<String>(TokenCacheKey); return String.IsNullOrWhiteSpace(token) ? GetToken() : token; }
        }

        private static String GetToken()
        {
            const string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
            var obj = JObject.Parse(string.Format(url, AppId, AppSecret).GetJsonFromUrl());
            var accessToken = obj["access_token"].ToString();
            Memcached.Set(TokenCacheKey, accessToken, new TimeSpan(0, 0, 0, obj["expires_in"].ToObject<int>() - 60));
            return accessToken;
        }
    }
}
