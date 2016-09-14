using System;
using System.Text;
using System.Web;
using ND.MCJ.Framework;

namespace ND.MCJ.AOP.Logging
{
    public static class LogType
    {
        /// <summary>
        /// 记录ASP.NET程序全局未处理异常
        /// </summary>
        /// <param name="ex">Exception异常</param>
        public static void LogGlobal(Exception ex)
        {
            var builder = BaseBuilder.Append("Exception:   ").Append(ex).Append(Environment.NewLine)
             .Append("------------------------------------------------------------------------------");
            Logger.Error(HttpUtility.UrlDecode(builder.ToString()));
        }

        /// <summary>
        /// 记录服务端接口异常
        /// </summary>
        /// <param name="ex">Exception异常</param>
        /// <param name="caption">标题</param>
        public static void LogService(Exception ex, string caption)
        {
            var builder = new StringBuilder().Append(Environment.NewLine)
            .Append("Caption:     ").Append(caption).Append(Environment.NewLine).Append(BaseBuilder)
            .Append("Exception:   ").Append(ex).Append(Environment.NewLine)
            .Append("-------------------------------------------------------------------------------");
            Logger.Error(HttpUtility.UrlDecode(builder.ToString()));
        }


        /// <summary>
        /// 记录Browser网页异常
        /// </summary>
        /// <param name="ex">Exception异常</param>
        /// <param name="caption">标题</param>
        public static void LogWebPage(Exception ex, String caption)
        {
            var builder = new StringBuilder().Append(Environment.NewLine)
            .Append("Caption:     ").Append(caption).Append(Environment.NewLine).Append(BaseBuilder)
            .Append("UrlReferrer:   ").Append(RequestHelper.UrlReferrer).Append(Environment.NewLine)
            .Append("Cookies:     ").Append(HttpUtility.UrlDecode(RequestHelper.Cookies.ToJson()).Replace("\r\n", "|")).Append(Environment.NewLine)
            .Append("Exception:   ").Append(ex).Append(Environment.NewLine)
            .Append("-------------------------------------------------------------------------------");
            Logger.Error(HttpUtility.UrlDecode(builder.ToString()));
        }

        /// <summary>
        /// 调试日志
        /// </summary>
        /// <param name="response">响应内容</param>
        /// <param name="caption">标题</param>
        public static void Debug(Object response, String caption)
        {
            var builder = new StringBuilder().Append(Environment.NewLine)
            .Append("Caption:     ").Append(caption).Append(Environment.NewLine).Append(BaseBuilder)
            .Append("Response:   ").Append(response.ToJson()).Append(Environment.NewLine)
            .Append("-------------------------------------------------------------------------------");
            Logger.Error(HttpUtility.UrlDecode(builder.ToString()));
        }

        /// <summary>
        /// 基础信息
        /// </summary>
        private static StringBuilder BaseBuilder
        {
            get
            {
                return new StringBuilder().Append(Environment.NewLine)
                .Append("ServerIP:    ").Append(RequestHelper.ServerIP).Append(Environment.NewLine)
                .Append("RemoteIP:    ").Append(RequestHelper.RemoteIP).Append(Environment.NewLine)
                .Append("UserAgent:   ").Append(RequestHelper.UserAgent).Append(Environment.NewLine)
                .Append("Request:     ").Append(RequestHelper.Request.ToString()).Append(Environment.NewLine)
                .Append("Parameter:     ").Append(RequestHelper.Parameters.ToString()).Append(Environment.NewLine)
                .Append("AbsoluteUri: ").Append(RequestHelper.AbsoluteUri).Append(Environment.NewLine);
            }
        }
    }
}
