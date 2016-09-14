using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.MCJ.Model
{
    public class RequestModel
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// 签名密钥
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        ///  密钥Token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 平台类型 1 Android 2 iPhone 3 H5
        /// </summary>
        public int Platform { get; set; }
    }
    /// <summary>
    /// 平台类型
    /// </summary>
    public enum Platform
    {
        Android = 1,
        IOS = 2,
        HTML5 = 3
    }
}