using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ND.MCJ.AOP.Logging;
using ND.MCJ.Framework;
using ServiceStack.Text;

namespace ND.MCJ.Tenpay
{
    public static class TenpayService
    {
        /// <summary>
        /// 企业付款，用于用户提现
        /// </summary>
        /// <param name="tData">请求企业付款接口的参数</param>
        /// <param name="timeout">超时时间</param>
        /// <returns>成功时返回调用结果，其他抛异常</returns>
        public static TenpayData EnterprisePay(TenpayData tData, int timeout = 10)
        {
            #region 检测必填参数
            if (!tData.IsSet("partner_trade_no"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数partner_trade_no！"); }
            if (!tData.IsSet("openid"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数openid！"); }
            if (!tData.IsSet("re_user_name"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数re_user_name！"); }
            if (!tData.IsSet("amount"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数amount！"); }
            if (!tData.IsSet("desc"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数desc！"); }
            if (!tData.IsSet("spbill_create_ip"))
            { throw new TenpayException("提交企业付款接口中，缺少必填参数spbill_create_ip！"); }
            #endregion

            tData.SetValue("check_name", "OPTION_CHECK");
            tData.SetValue("spbill_create_ip", RequestHelper.RemoteIP);//终端IP

            const string url = "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/transfers";
            return url.PostData(tData, true, timeout);
        }

        /// <summary>
        /// 提交被扫支付API
        /// 收银员使用扫码设备读取微信用户刷卡授权码以后，二维码或条码信息传送至商户收银台，</summary>
        /// 由商户收银台或者商户后台调用该接口发起支付。
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData MicroScanPay(TenpayData tData, int timeout = 10)
        {
            #region 检测必填参数
            if (!tData.IsSet("body"))
            { throw new TenpayException("提交被扫支付API接口中，缺少必填参数body！"); }
            if (!tData.IsSet("out_trade_no"))
            { throw new TenpayException("提交被扫支付API接口中，缺少必填参数out_trade_no！"); }
            if (!tData.IsSet("total_fee"))
            { throw new TenpayException("提交被扫支付API接口中，缺少必填参数total_fee！"); }
            if (!tData.IsSet("auth_code"))
            { throw new TenpayException("提交被扫支付API接口中，缺少必填参数auth_code！"); }
            #endregion

            tData.SetValue("spbill_create_ip", RequestHelper.RemoteIP);//终端IP
            const string url = "https://api.mch.weixin.qq.com/pay/micropay";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData OrderQuery(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("out_trade_no") && !tData.IsSet("transaction_id"))
            { throw new TenpayException("订单查询接口中，out_trade_no、transaction_id至少填一个！"); }
            #endregion
            const string url = "https://api.mch.weixin.qq.com/pay/orderquery";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        ///  撤销订单API接口
        /// </summary>
        /// <param name="tData">提交给撤销订单API接口的参数，out_trade_no和transaction_id必填一个</param>
        /// <param name="timeout">接口超时时间</param>
        /// <returns> 成功时返回API调用结果，其他抛异常</returns>
        public static TenpayData Reverse(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("out_trade_no") && !tData.IsSet("transaction_id"))
            { throw new TenpayException("撤销订单API接口中，参数out_trade_no和transaction_id必须填写一个！"); }
            #endregion

            const string url = "https://api.mch.weixin.qq.com/secapi/pay/reverse";
            return url.PostData(tData, true, timeout);
        }

        /// <summary>
        /// 申请退款
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData Refund(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("out_trade_no") && !tData.IsSet("transaction_id"))
            { throw new TenpayException("退款申请接口中，out_trade_no、transaction_id至少填一个！"); }
            if (!tData.IsSet("out_refund_no"))
            { throw new TenpayException("退款申请接口中，缺少必填参数out_refund_no！"); }
            if (!tData.IsSet("total_fee"))
            { throw new TenpayException("退款申请接口中，缺少必填参数total_fee！"); }
            if (!tData.IsSet("refund_fee"))
            { throw new TenpayException("退款申请接口中，缺少必填参数refund_fee！"); }
            if (!tData.IsSet("op_user_id"))
            { throw new TenpayException("退款申请接口中，缺少必填参数op_user_id！"); }
            #endregion

            const string url = "https://api.mch.weixin.qq.com/secapi/pay/refund";
            return url.PostData(tData, true, timeout);
        }

        /// <summary> 
        /// 查询退款
        /// 提交退款申请后，通过该接口查询退款状态。退款有一定延时，
        /// 用零钱支付的退款20分钟内到账，银行卡支付的退款3个工作日后重新查询退款状态。
        /// out_refund_no、out_trade_no、transaction_id、refund_id四个参数必填一个
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData RefundQuery(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("out_refund_no") && !tData.IsSet("out_trade_no") &&
                   !tData.IsSet("transaction_id") && !tData.IsSet("refund_id"))
            { throw new TenpayException("退款查询接口中，out_refund_no、out_trade_no、transaction_id、refund_id四个参数必填一个！"); }
            #endregion

            const string url = "https://api.mch.weixin.qq.com/pay/refundquery";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        /// 下载对账单
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData DownloadBill(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("bill_date"))
            { throw new TenpayException("对账单接口中，缺少必填参数bill_date！"); }
            #endregion

            const string url = "https://api.mch.weixin.qq.com/pay/downloadbill";
            return url.PostData(tData, false, timeout);
        }

        /// <summary> 
        /// 转换短链接
        /// 该接口主要用于扫码原生支付模式一中的二维码链接转成短链接(weixin://wxpay/s/XXXXXX)，
        /// 减小二维码数据量，提升扫描速度和精确度。
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData ShortUrl(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("long_url"))
            { throw new TenpayException("需要转换的URL，签名用原串，传输需URL encode！"); }
            #endregion

            const string url = "https://api.mch.weixin.qq.com/tools/shorturl";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        ///  统一下单
        ///  @param WxPaydata inputObj 提交给统一下单API的参数
        ///  @param int timeOut 超时时间
        ///  @throws WxPayException
        ///  @return 成功时返回，其他抛异常 
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData UnifiedOrder(TenpayData tData, int timeout = 6)
        {
            #region 检测必填参数
            if (!tData.IsSet("out_trade_no"))
            { throw new TenpayException("缺少统一支付接口必填参数out_trade_no！"); }
            if (!tData.IsSet("body"))
            { throw new TenpayException("缺少统一支付接口必填参数body！"); }
            if (!tData.IsSet("total_fee"))
            { throw new TenpayException("缺少统一支付接口必填参数total_fee！"); }
            if (!tData.IsSet("trade_type"))
            { throw new TenpayException("缺少统一支付接口必填参数trade_type！"); }
            //关联参数
            if (tData.GetValue("trade_type").ToString() == "JSAPI" && !tData.IsSet("openid"))
            { throw new TenpayException("统一支付接口中，缺少必填参数openid！trade_type为JSAPI时，openid为必填参数！"); }
            if (tData.GetValue("trade_type").ToString() == "NATIVE" && !tData.IsSet("product_id"))
            { throw new TenpayException("统一支付接口中，缺少必填参数product_id！trade_type为JSAPI时，product_id为必填参数！"); }
            #endregion

            //异步通知url未设置，则使用配置文件中的url
            if (!tData.IsSet("notify_url")) { tData.SetValue("notify_url", TenpayMain.NotifyUrl); }
            tData.SetValue("spbill_create_ip", RequestHelper.RemoteIP);//终端IP
            const string url = "https://api.mch.weixin.qq.com/pay/unifiedorder";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData CloseOrder(TenpayData tData, int timeout = 6)
        {
            if (!tData.IsSet("out_trade_no"))
            { throw new TenpayException("关闭订单接口中，out_trade_no必填！"); }

            const string url = "https://api.mch.weixin.qq.com/pay/closeorder";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        ///  测速上报
        /// </summary>
        /// <param name="interfaceUrl"></param>
        /// <param name="timeCost"></param>
        /// <param name="tData"></param>
        private static void ReportCostTime(string interfaceUrl, int timeCost, TenpayData tData)
        {
            //如果不需要进行上报
            if (TenpayMain.ReportLevel == 0) return;
            //如果仅失败上报
            if (TenpayMain.ReportLevel == 1 && tData.IsSet("return_code") && tData.GetValue("return_code").ToString() == "SUCCESS" &&
             tData.IsSet("result_code") && tData.GetValue("result_code").ToString() == "SUCCESS")
            { return; }
            //上报逻辑
            var data = new TenpayData();
            data.SetValue("interface_url", interfaceUrl);
            data.SetValue("execute_time_", timeCost);
            //返回状态码
            if (tData.IsSet("return_code"))
            { data.SetValue("return_code", tData.GetValue("return_code")); }
            //返回信息
            if (tData.IsSet("return_msg"))
            { data.SetValue("return_msg", tData.GetValue("return_msg")); }
            //业务结果
            if (tData.IsSet("result_code"))
            { data.SetValue("result_code", tData.GetValue("result_code")); }
            //错误代码
            if (tData.IsSet("err_code"))
            { data.SetValue("err_code", tData.GetValue("err_code")); }
            //错误代码描述
            if (tData.IsSet("err_code_des"))
            { data.SetValue("err_code_des", tData.GetValue("err_code_des")); }
            //商户订单号
            if (tData.IsSet("out_trade_no"))
            { data.SetValue("out_trade_no", tData.GetValue("out_trade_no")); }
            //设备号
            if (tData.IsSet("device_info"))
            { data.SetValue("device_info", tData.GetValue("device_info")); }

            try
            { Report(data); }
            catch (TenpayException ex) { Logger.Error(ex); }
        }

        /// <summary>
        /// 测速上报接口实现
        /// </summary>
        /// <param name="tData"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static TenpayData Report(TenpayData tData, int timeout = 1)
        {
            #region 检测必填参数
            if (!tData.IsSet("interface_url"))
            { throw new TenpayException("接口URL，缺少必填参数interface_url！"); }
            if (!tData.IsSet("return_code"))
            { throw new TenpayException("返回状态码，缺少必填参数return_code！"); }
            if (!tData.IsSet("result_code"))
            { throw new TenpayException("业务结果，缺少必填参数result_code！"); }
            if (!tData.IsSet("user_ip"))
            { throw new TenpayException("访问接口IP，缺少必填参数user_ip！"); }
            if (!tData.IsSet("execute_time_"))
            { throw new TenpayException("接口耗时，缺少必填参数execute_time_！"); }
            #endregion

            tData.SetValue("user_ip", RequestHelper.RemoteIP);//终端ip
            tData.SetValue("time", DateTime.Now.ToString("yyyyMMddHHmmss"));//商户上报时间	 
            const string url = "https://api.mch.weixin.qq.com/payitil/report";
            return url.PostData(tData, false, timeout);
        }

        /// <summary>
        /// 根据当前系统时间加随机序列来生成订单号
        /// </summary>
        /// <returns></returns>
        public static string MakeOutTradeNo()
        {
            return string.Format("{0}{1}{2}", TenpayMain.MchId, DateTime.Now.ToString("yyyyMMddHHmmss"), new Random().Next(999));
        }

        public static string MakeTimeStamp()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }

        public static string MakeNonceStr() { return Guid.NewGuid().ToString("N"); }

        /// <summary>
        /// 向微信服务器发送请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="tData">微信交互数据结构</param>
        /// <param name="isUseCert">是否使用证书</param>
        /// <param name="timeout">超时时间</param>
        /// <returns></returns>
        private static TenpayData PostData(this String url, TenpayData tData, bool isUseCert, int timeout)
        {
            tData.SetValue("appid", TenpayMain.AppId);//公众账号ID
            tData.SetValue("mch_id", TenpayMain.MchId);//商户号
            tData.SetValue("nonce_str", MakeNonceStr());//随机字符串
            tData.SetValue("sign", tData.MakeSign());//签名
            var start = DateTime.Now;
            var response = url.PostStringToUrl(tData.ToXml(), requestFilter: s =>
            {
                s.Timeout = timeout; if (isUseCert)
                { s.ClientCertificates.Add(new X509Certificate2(TenpayMain.SSLCertPath, TenpayMain.SSLCertPassword)); }
            });
            tData = new TenpayData(); tData.FromXml(response);
            ReportCostTime(url, (int)((DateTime.Now - start).TotalMilliseconds), tData);//测速上报
            return tData;
        }
    }
}
