using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 系统账户表
    /// </summary>
    [Table("SystemAccounts")]
    public class SystemAccounts : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysUserId")]
        [Key]
        public int SysUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// 账户余额
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

