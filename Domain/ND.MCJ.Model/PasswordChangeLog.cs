using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 密码修改记录
    /// </summary>
    [Table("PasswordChangeLog")]
    public class PasswordChangeLog : BaseModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DisplayName("PwdLogId")]
        [Key]
        public int PwdLogId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 原密码
        /// </summary>
        [DisplayName("OldPwd")]
        public String OldPwd { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        [DisplayName("NewPwd")]
        public String NewPwd { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

