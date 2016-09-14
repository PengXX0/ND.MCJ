using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 充值记录表
    /// </summary>
    [Table("RechargeLogs")]
    public class RechargeLogs : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RechargeId")]
        [Key]
        public int RechargeId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 审核人    （后台账号Id）
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// 外键，对应UserAccounts
        /// </summary>
        [DisplayName("UserAccountId")]
        public int UserAccountId { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        [DisplayName("RechargeAmount")]
        public decimal RechargeAmount { get; set; }
        /// <summary>
        /// 0失败  1成功
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 验证日期
        /// </summary>
        [DisplayName("VerifiedDate")]
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// 最终充值金额
        /// </summary>
        [DisplayName("FinallyRechargeAmount")]
        public decimal FinallyRechargeAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 失败或通过原因
        /// </summary>
        [DisplayName("Reason")]
        public String Reason { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

