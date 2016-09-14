using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace NC.MCJ.WebApi.Models
{
    public class ResponseModel
    {
        /// <summary>
        /// 返回编码
        /// </summary>
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回内容,若为空，则返回空字符串
        /// </summary>
        private object _data;
        public object Data
        {
            get { return _data ?? new Object(); }
            set { _data = value; }
        }
    }

    /// <summary>
    /// 返回编码
    /// </summary>
    public enum ResponseCode
    {
        /// <summary>
        /// 请求成功(200)
        /// </summary>
        Success = HttpStatusCode.OK,
        /// <summary>
        /// 请求错误(400)
        /// </summary>
        RequestError = HttpStatusCode.BadRequest,
        /// <summary>
        /// 密钥错误(406)
        /// </summary>
        TokenError = HttpStatusCode.Forbidden,
        /// <summary>
        /// 未登录(401)
        /// </summary>
        NoLogin = HttpStatusCode.Unauthorized
    }
}