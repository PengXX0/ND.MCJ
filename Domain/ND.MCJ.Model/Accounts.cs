using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户账户
    /// </summary>
    [Table("Accounts")]
    public class Accounts : BaseModel
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 账户总额（包含锁定金额）
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 支持众筹项目锁定金额
        /// </summary>
        [DisplayName("LockedBalance")]
        public decimal LockedBalance { get; set; }
        /// <summary>
        /// 提现锁定金额
        /// </summary>
        [DisplayName("DrawLocked")]
        public decimal DrawLocked { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

