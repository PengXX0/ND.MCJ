using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 微信账单详情
    /// </summary>
    [Table("WechatBillDetails")]
    public class WechatBillDetails : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("WechatBillId")]
        [Key]
        public int WechatBillId { get; set; }
        /// <summary>
        /// 对账单日期
        /// </summary>
        [DisplayName("BillDate")]
        public String BillDate { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        [DisplayName("TradeTime")]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// 公众号Id
        /// </summary>
        [DisplayName("AppId")]
        public String AppId { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        [DisplayName("MchId")]
        public String MchId { get; set; }
        /// <summary>
        /// 子商户号
        /// </summary>
        [DisplayName("SubMchId")]
        public String SubMchId { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        [DisplayName("DeviceInfo")]
        public String DeviceInfo { get; set; }
        /// <summary>
        /// 微信支付订单号
        /// </summary>
        [DisplayName("TransactionId")]
        public String TransactionId { get; set; }
        /// <summary>
        /// 商户订单号
        /// </summary>
        [DisplayName("OutTradeNo")]
        public String OutTradeNo { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        [DisplayName("TradeType")]
        public String TradeType { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        [DisplayName("TradeStatus")]
        public String TradeStatus { get; set; }
        /// <summary>
        /// 付款银行
        /// </summary>
        [DisplayName("BankType")]
        public String BankType { get; set; }
        /// <summary>
        /// 货币种类
        /// </summary>
        [DisplayName("FeeType")]
        public String FeeType { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        [DisplayName("TotalFee")]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 代金券或立减优惠金额
        /// </summary>
        [DisplayName("CouponFee")]
        public decimal CouponFee { get; set; }
        /// <summary>
        /// 商户退款单号
        /// </summary>
        [DisplayName("OutRefundNo")]
        public String OutRefundNo { get; set; }
        /// <summary>
        /// 微信退款单号
        /// </summary>
        [DisplayName("RefundId")]
        public String RefundId { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        [DisplayName("RefundFee")]
        public decimal RefundFee { get; set; }
        /// <summary>
        /// 代金券或立减优惠退款金额
        /// </summary>
        [DisplayName("CouponRefundFee")]
        public decimal CouponRefundFee { get; set; }
        /// <summary>
        /// 退款类型
        /// </summary>
        [DisplayName("RefundType")]
        public String RefundType { get; set; }
        /// <summary>
        /// 退款状态
        /// </summary>
        [DisplayName("RefundStatus")]
        public String RefundStatus { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [DisplayName("GoodsName")]
        public String GoodsName { get; set; }
        /// <summary>
        /// 商家数据包
        /// </summary>
        [DisplayName("Attach")]
        public String Attach { get; set; }
        /// <summary>
        /// 手续费
        /// </summary>
        [DisplayName("CounterFee")]
        public decimal CounterFee { get; set; }
        /// <summary>
        /// 费率
        /// </summary>
        [DisplayName("Rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

