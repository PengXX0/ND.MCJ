using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using ND.MCJ.AOP.Logging;

namespace ND.MCJ.Tenpay
{
    /// <summary>
    /// 回调处理基类
    /// 主要负责接收微信支付后台发送过来的数据，对数据进行签名验证
    /// 子类在此类基础上进行派生并重写自己的回调处理过程
    /// </summary>
    public class TenpayNotify
    {
        public HttpRequestBase Request { get; set; }
        public TenpayNotify(HttpRequestBase request) { Request = request; }

        /// <summary>
        /// 接收从微信支付后台发送过来的数据并验证签名
        /// </summary>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public TenpayData GetNotifyData(String secretKey = "")
        {
            var s = Request.InputStream;
            int count; var buffer = new byte[1024]; var builder = new StringBuilder();
            while ((count = s.Read(buffer, 0, 1024)) > 0) { builder.Append(Encoding.UTF8.GetString(buffer, 0, count)); }
            s.Flush(); s.Close(); s.Dispose();
            var data = new TenpayData();
            try { data.FromXml(builder.ToString(), secretKey); }
            catch (TenpayException ex)
            {
                data = new TenpayData();
                data.SetValue("return_code", "FAIL");
                data.SetValue("return_msg", ex.Message);
                Logger.Error(GetType() + "  Sign check error : " + data.ToXml());
                return data;
            }
            return data;
        }
        //派生类需要重写这个方法，进行不同的回调处理
        public virtual void ProcessNotify() { }
    }
}
