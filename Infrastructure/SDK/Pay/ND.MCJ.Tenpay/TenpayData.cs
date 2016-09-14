using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using ND.MCJ.AOP.Logging;

namespace ND.MCJ.Tenpay
{
    /// <summary>
    /// 微信交互数据包结构
    /// </summary>
    public class TenpayData
    {
        public TenpayData() { }

        private readonly SortedDictionary<string, object> _dic = new SortedDictionary<string, object>();

        public void SetValue(string key, object value) { _dic[key] = value; }

        public object GetValue(string key) { object o; return _dic.TryGetValue(key, out o) ? o : null; }

        public bool IsSet(string key) { object o; return _dic.TryGetValue(key, out o); }

        public SortedDictionary<string, object> FromXml(String xml, String secretKey = "")
        {
            if (String.IsNullOrWhiteSpace(xml)) { ExceptionHandle("将空的xml串转换为WxPayData不合法!"); }
            var xmlDoc = new XmlDocument(); xmlDoc.LoadXml(xml);
            foreach (var xe in xmlDoc.FirstChild.ChildNodes.Cast<XmlElement>())
            { _dic[xe.Name] = xe.InnerText; }
            if ((string)_dic["return_code"] != "SUCCESS") { return _dic; }
            if (!CheckSign(secretKey)) { ExceptionHandle("签名验证错误！"); }
            return _dic;
        }

        public string ToXml()
        {
            if (!_dic.Any()) { ExceptionHandle("WxPayData数据为空!"); }
            var xml = new StringBuilder("<xml>");
            foreach (var pair in _dic)
            {
                if (pair.Value == null) { ExceptionHandle("WxPayData内部含有值为null的字段!"); }
                if (pair.Value is int) { xml.AppendFormat("<{0}>{1}</{0}>", pair.Key, pair.Value); }
                else if (pair.Value is String) { xml.AppendFormat("<{0}><![CDATA[{1}]]></{0}>", pair.Key, pair.Value); }
                else { ExceptionHandle("WxPayData字段数据类型错误!"); }
            }
            return xml.Append("</xml>").ToString();
        }

        public string ToQueryString()
        {
            var buffList = new List<String>();
            foreach (var pair in _dic)
            {
                if (pair.Value == null) { ExceptionHandle("WxPayData内部含有值为null的字段!"); }
                if (pair.Key != "sign" && String.IsNullOrWhiteSpace(pair.Value.ToString()))
                { buffList.Add(pair.Key + "=" + pair.Value); }
            }
            return String.Join("&", buffList);
        }

        public string ToJson() { return JsonConvert.SerializeObject(_dic); }

        public string ToPrintStr()
        {
            var strList = new List<String>();
            foreach (var pair in _dic)
            {
                if (pair.Value == null) { ExceptionHandle("WxPayData内部含有值为null的字段!"); }
                strList.Add(string.Format("{0}={1}", pair.Key, pair.Value));
            }
            return String.Join("</br>", strList);
        }

        /// <summary>
        /// 检测签名是否正确  
        /// 正确返回true，错误抛异常
        /// </summary>
        /// <param name="secretKey">若为空，则默认为微信App支付</param>
        /// <returns></returns>
        public bool CheckSign(String secretKey = "")
        {
            if (!IsSet("sign")) { ExceptionHandle("签名不存在！"); }
            if (GetValue("sign") == null || String.IsNullOrWhiteSpace(GetValue("sign").ToString()))
            { ExceptionHandle("WxPayData签名存在但不合法!"); }
            return GetValue("sign").ToString() == MakeSign(secretKey);
        }

        /// <summary>
        /// 生成签名，详见签名生成算法
        /// return 签名, sign字段不参加签名
        /// </summary>
        /// <param name="secretKey">若为空，则默认为微信App支付</param>
        /// <returns></returns>
        public string MakeSign(String secretKey = "")
        {
            var str = ToQueryString() + ("&key=" + (String.IsNullOrWhiteSpace(secretKey) ? TenpayMain.SecretKey : secretKey));
            var bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
            var stringBuilder = new StringBuilder();
            foreach (var b in bytes) { stringBuilder.Append(b.ToString("x2")); }
            return stringBuilder.ToString().ToUpper();
        }

        public SortedDictionary<string, object> GetValues() { return _dic; }

        public void ExceptionHandle(String message)
        {
            Logger.Error(GetType() + " " + message);
            throw new TenpayException(message);
        }
    }
}
