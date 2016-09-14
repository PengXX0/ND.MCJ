using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 微信账单统计
    /// </summary>
    [Table("WechatBill")]
    public class WechatBill : BaseModel
    {
        /// <summary>
        /// 主键 自增
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
        /// 总交易单数
        /// </summary>
        [DisplayName("TotalTradeCount")]
        public int TotalTradeCount { get; set; }
        /// <summary>
        /// 总交易额
        /// </summary>
        [DisplayName("TotalTradeAmount")]
        public decimal TotalTradeAmount { get; set; }
        /// <summary>
        /// 总退款金额
        /// </summary>
        [DisplayName("TotalRefundAmount")]
        public decimal TotalRefundAmount { get; set; }
        /// <summary>
        /// 代金券或立减优惠金额
        /// </summary>
        [DisplayName("TotalCouponAmount")]
        public decimal TotalCouponAmount { get; set; }
        /// <summary>
        /// 手续费总金额
        /// </summary>
        [DisplayName("TotalCounterAmount")]
        public decimal TotalCounterAmount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

