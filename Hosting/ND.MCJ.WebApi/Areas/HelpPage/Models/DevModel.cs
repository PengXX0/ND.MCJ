using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NC.MCJ.WebApi.Areas.HelpPage.Models
{
    public class DevModel
    {
        /// <summary>
        /// 请求地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public string Parma { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        public int? Platform { get; set; }
    }
}