using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SystemWithdrawLogs")]
    public class SystemWithdrawLogs : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysWithdrawLogId")]
        [Key]
        public int SysWithdrawLogId { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        [DisplayName("BatchNo")]
        public String BatchNo { get; set; }
        /// <summary>
        /// 通知时间
        /// </summary>
        [DisplayName("NotifyTime")]
        public DateTime NotifyTime { get; set; }
        /// <summary>
        /// 通知类型
        /// </summary>
        [DisplayName("NotifyType")]
        public String NotifyType { get; set; }
        /// <summary>
        /// 通知Id
        /// </summary>
        [DisplayName("NotifyId")]
        public String NotifyId { get; set; }
        /// <summary>
        /// 签名类型
        /// </summary>
        [DisplayName("SignType")]
        public String SignType { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        [DisplayName("Sign")]
        public String Sign { get; set; }
        /// <summary>
        /// 付款账号ID
        /// </summary>
        [DisplayName("PayUserId")]
        public String PayUserId { get; set; }
        /// <summary>
        /// 付款账号姓名
        /// </summary>
        [DisplayName("PayUserName")]
        public String PayUserName { get; set; }
        /// <summary>
        /// 付款账号
        /// </summary>
        [DisplayName("PayAccountNo")]
        public String PayAccountNo { get; set; }
        /// <summary>
        /// 转账成功的详细信息
        /// </summary>
        [DisplayName("SuccessDetails")]
        public String SuccessDetails { get; set; }
        /// <summary>
        /// 转账失败的详细信息
        /// </summary>
        [DisplayName("FailDetails")]
        public String FailDetails { get; set; }
    }
}

