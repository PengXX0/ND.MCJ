using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ND.MCJ.Model
{
    public class ResponseModel
    {
        /// <summary>
        /// 返回编码
        /// </summary>
        private HttpStatusCode? _code;
        public HttpStatusCode Code
        {
            get { return _code ?? HttpStatusCode.OK; }
            set { _code = value; }
        }

        /// <summary>
        /// 返回消息
        /// </summary>
        private string _message;
        public string Message
        {
            get { return _message ?? "操作成功"; }
            set { _message = value; }
        }

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
        /// 签名错误（203）
        /// </summary>
        SignError = HttpStatusCode.NonAuthoritativeInformation,
        /// <summary>
        /// 未登录(401)
        /// </summary>
        NoLogin = HttpStatusCode.Unauthorized
    }
}