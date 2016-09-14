using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    [Table("Users")]
    public class Users : BaseModel
    {
        /// <summary>
        /// 用户Id，自增
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 用户名,
        /// </summary>
        [DisplayName("UserName")]
        public String UserName { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// 图像
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// 个性签名
        /// </summary>
        [DisplayName("Signature")]
        public String Signature { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("Password")]
        public String Password { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        [DisplayName("Email")]
        public String Email { get; set; }
        /// <summary>
        /// 状态：0锁定  1黑名单  2正常
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 来源：1App 2Android 3H5
        /// </summary>
        [DisplayName("FromId")]
        public int FromId { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        [DisplayName("LastLoginDate")]
        public DateTime LastLoginDate { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 是否是黑名单 0否 1是
        /// </summary>
        [DisplayName("IsBlackList")]
        public int IsBlackList { get; set; }
        /// <summary>
        /// 类型Id 0正常账号  1营销账号
        /// </summary>
        [DisplayName("TypeId")]
        public int? TypeId { get; set; }
    }
}

