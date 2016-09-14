using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 账户表详情，账单
    /// </summary>
    [Table("SystemAccountDetails")]
    public class SystemAccountDetails : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("SysAccountDetailId")]
        [Key]
        public int SysAccountDetailId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysUserId")]
        public int SysUserId { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 系统账户所剩余额，当前交易结束之后的余额
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

