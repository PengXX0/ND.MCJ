using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("InpourOnlines")]
    public class InpourOnlines : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OnlineId")]
        [Key]
        public int OnlineId { get; set; }
        /// <summary>
        /// 交易号，与第三方支付平台唯一标识
        /// </summary>
        [DisplayName("DealingId")]
        public String DealingId { get; set; }
        /// <summary>
        /// 支持方式   直接充值支持
        /// </summary>
        [DisplayName("TransactionId")]
        public String TransactionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        ///  1微信，2支付宝，3京东
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        ///  0 待支付  1成功  2失败   
        /// </summary>
        [DisplayName("ResultId")]
        public int ResultId { get; set; }
        /// <summary>
        /// 充值金额   
        /// </summary>
        [DisplayName("TotalFee")]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// 实际冲入金额   
        /// </summary>
        [DisplayName("TotalPay")]
        public decimal TotalPay { get; set; }
        /// <summary>
        /// 即时充值成功时间   
        /// </summary>
        [DisplayName("ReturnDate")]
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 交易关闭时间   
        /// </summary>
        [DisplayName("DealingDate")]
        public DateTime DealingDate { get; set; }
        /// <summary>
        /// 发起付款时间，也就是充值页面点确认   
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

