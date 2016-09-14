using ND.MCJ.AOP.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ND.MCJ.AOP.Security
{
    public static class WebApiAuthorize
    {
        /// <summary>
        /// 用来生成Token的Key在MemCached的缓存Key
        /// </summary>
        public const String McjAuthrizeDynamicKey = "MCJ_Authrize_Dynamic_Key";
        /// <summary>
        /// 在MemCached存储用户的认证信息Key
        /// </summary>
        public const String McjAuthrizeTokenKey = "MCJ_User_Authrize_";

        /// <summary>
        /// 生成认证Token的Key，每天零点过期一次,(用于登录成功后生成Token)
        /// </summary>
        private static String AuthrizeKey
        {
            get
            {
                var value = Memcached.Get<String>(McjAuthrizeDynamicKey);
                if (!String.IsNullOrWhiteSpace(value)) return value;
                value = Guid.NewGuid().ToString("N").Substring(0, 16);
                Memcached.Set(McjAuthrizeDynamicKey, value, DateTime.Now.AddDays(1).Date - DateTime.Now);
                return value;
            }
        }

        /// <summary>
        /// 验证Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static bool VarifyToken(String token)
        {
            var arry = Encoding.UTF8.GetString(Convert.FromBase64String(token)).Split('|');
            if (arry.Length != 2) { return false; }
            var value = Memcached.Get<String>(McjAuthrizeTokenKey + arry[1]);
            return value == arry[0].Replace(" ", "+");
        }

        /// <summary>
        /// 登录认证通过，生成Token
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">用户密码被md5两次之后的值</param>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public static String MakeToken(String username, String password, int userId)
        {
            var dic = new Dictionary<String, String> { { "USERNAME", username }, { "PASSWORD", password } };
            var signStr = dic.OrderBy(q => q.Key).Aggregate("", (c, q) => c + dic[q.Key] + "|");
            var sb = new StringBuilder(32);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] t = md5.ComputeHash(Encoding.UTF8.GetBytes(signStr + AuthrizeKey));
            foreach (var t1 in t) { sb.Append(t1.ToString("x").PadLeft(2, '0')); }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(sb + "|" + userId));
        }
    }
}
