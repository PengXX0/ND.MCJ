using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("WXPayList$")]
    public class WXPayList$ : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("交易时间")]
        public DateTime 交易时间 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("微信支付单号")]
        public String 微信支付单号 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("商户订单号")]
        public String 商户订单号 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("商户号")]
        public double 商户号 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("appid")]
        public String appid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("下单用户")]
        public String 下单用户 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("交易状态")]
        public String 交易状态 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("支付成功时间")]
        public DateTime 支付成功时间 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("交易金额(元)")]
        public double 交易金额(元) { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("F10")]
        public String F10 { get; set; }
    }
}

