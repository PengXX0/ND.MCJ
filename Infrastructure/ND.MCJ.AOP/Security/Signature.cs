using ND.MCJ.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ND.MCJ.AOP.Security
{
    public class Signature
    {
        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public static bool VerifySign(NameValueCollection nv)
        {
            //H5接口免加密
            //if (nv.AllKeys.Contains("Platform") && nv["Platform"] == "3") { return true; }
            if (!(nv.AllKeys.Contains("Sign") && nv.AllKeys.Contains("PlatformId"))) return false;
            var sign = nv["Sign"].Replace(" ", "+");
            var dic = nv.ToDictionary(true);
            dic.Remove("Sign");
            var str = MakeSign(dic);
            return sign == str;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static string MakeSign(IDictionary<String, String> dic)
        {
            var appKey = System.Configuration.ConfigurationManager.AppSettings["AppSignatureKey"];
            var signStr = dic.OrderBy(q => q.Key).Aggregate("", (c, q) => c + dic[q.Key] + "|");
            var sb = new StringBuilder(32);
            MD5 md5 = new MD5CryptoServiceProvider();
            var t = md5.ComputeHash(Encoding.UTF8.GetBytes(signStr + appKey));
            foreach (var t1 in t) { sb.Append(t1.ToString("x").PadLeft(2, '0')); }
            return sb.ToString();
        }
    }
}
