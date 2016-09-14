using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户登录日志表
    /// </summary>
    [Table("UserLoginLog")]
    public class UserLoginLog : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("LoginId")]
        [Key]
        public int LoginId { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 用户输入密码
        /// </summary>
        [DisplayName("Password")]
        public int Password { get; set; }
        /// <summary>
        /// 0登录失败   1登录成功
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public int CreateDate { get; set; }
    }
}

