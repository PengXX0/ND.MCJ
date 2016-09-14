using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 提现记录表
    /// </summary>
    [Table("AccountWithDrawals")]
    public class AccountWithDrawals : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("WithDrawId")]
        [Key]
        public int WithDrawId { get; set; }
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
        /// 提现金额
        /// </summary>
        [DisplayName("WithDrawAmount")]
        public decimal WithDrawAmount { get; set; }
        /// <summary>
        /// 0待审核  1通过  2不通过 3提现处理中 4提现成功 5提现失败 6删除
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 验证日期
        /// </summary>
        [DisplayName("VerifiedDate")]
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// 最终提现金额
        /// </summary>
        [DisplayName("FinallyDrawAmount")]
        public decimal FinallyDrawAmount { get; set; }
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
        /// 请求流水号
        /// </summary>
        [DisplayName("DealingId")]
        public String DealingId { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        [DisplayName("BatchNo")]
        public String BatchNo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

