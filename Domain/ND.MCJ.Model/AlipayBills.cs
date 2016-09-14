using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 支付宝账单明细
    /// </summary>
    [Table("AlipayBills")]
    public class AlipayBills : BaseModel
    {
        /// <summary>
        /// Id主键 自增
        /// </summary>
        [DisplayName("AlipayBillId")]
        [Key]
        public int AlipayBillId { get; set; }
        /// <summary>
        /// 订单日期
        /// </summary>
        [DisplayName("BillDate")]
        public String BillDate { get; set; }
        /// <summary>
        /// 账务类型
        /// </summary>
        [DisplayName("Type")]
        public String Type { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        [DisplayName("BusinessType")]
        public String BusinessType { get; set; }
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [DisplayName("AlipayOrderNo")]
        public String AlipayOrderNo { get; set; }
        /// <summary>
        /// 商户订单号
        /// </summary>
        [DisplayName("MerchantOrderNo")]
        public String MerchantOrderNo { get; set; }
        /// <summary>
        /// 本方支付宝账户ID
        /// </summary>
        [DisplayName("SelfUserId")]
        public String SelfUserId { get; set; }
        /// <summary>
        /// 对方支付宝账户ID
        /// </summary>
        [DisplayName("OptUserId")]
        public String OptUserId { get; set; }
        /// <summary>
        /// 	收入金额
        /// </summary>
        [DisplayName("InAmount")]
        public decimal InAmount { get; set; }
        /// <summary>
        /// 支出金额
        /// </summary>
        [DisplayName("OutAmount")]
        public decimal OutAmount { get; set; }
        /// <summary>
        /// 当时账户的余额
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 账务备注说明
        /// </summary>
        [DisplayName("Memo")]
        public String Memo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateTime")]
        public DateTime CreateTime { get; set; }
    }
}

