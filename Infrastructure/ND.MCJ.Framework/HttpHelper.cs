using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace ND.MCJ.Framework
{
    public class RequestHelper
    {
        public static HttpRequest Request { get { return HttpContext.Current.Request; } }
        public static String UserAgent { get { return Request.UserAgent; } }
        public static String AbsoluteUri { get { return Request.Url.AbsoluteUri; } }
        public static String UrlReferrer { get { return Request.UrlReferrer == null ? "" : Request.UrlReferrer.ToString(); } }
        public static HttpCookieCollection Cookies { get { return Request.Cookies; } }
        public static NameValueCollection Parameters { get { Request.QueryString.Add(Request.Form); return Request.QueryString; } }
        public static String ServerIP
        {
            get
            {
                var machineIP = String.Empty;
                machineIP = Dns.GetHostAddresses(Dns.GetHostName())
                    .Where(ip => ip.AddressFamily == AddressFamily.InterNetwork)
                    .Aggregate(machineIP, (current, ip) => current + (ip + "; "));
                return machineIP.EndsWith("; ") ? machineIP.Substring(0, machineIP.Length - 2) : machineIP;
            }
        }
        public static String RemoteIP
        {
            get
            {
                var result = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (string.IsNullOrEmpty(result))
                { result = Request.ServerVariables["REMOTE_ADDR"]; }
                if (string.IsNullOrEmpty(result))
                { result = Request.Headers["X-Real-IP"]; }
                if (string.IsNullOrEmpty(result))
                { result = Request.UserHostAddress; }
                return result;
            }
        }
    }
}
