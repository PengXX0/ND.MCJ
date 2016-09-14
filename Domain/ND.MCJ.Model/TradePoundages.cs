using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("TradePoundages")]
    public class TradePoundages : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("TradePoundageID")]
        [Key]
        public int TradePoundageID { get; set; }
        /// <summary>
        /// 交易类型  1 充值 2提现 3服务费
        /// </summary>
        [DisplayName("TradeType")]
        public int TradeType { get; set; }
        /// <summary>
        /// 最小金额
        /// </summary>
        [DisplayName("MinRange")]
        public decimal MinRange { get; set; }
        /// <summary>
        /// 最大金额
        /// </summary>
        [DisplayName("MaxRange")]
        public decimal MaxRange { get; set; }
        /// <summary>
        /// 手续费
        /// </summary>
        [DisplayName("Poundage")]
        public double Poundage { get; set; }
        /// <summary>
        /// 1启用 2禁用
        /// </summary>
        [DisplayName("StatusID")]
        public int StatusID { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

