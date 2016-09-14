using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户验证信息表
    /// </summary>
    [Table("UserValidates")]
    public class UserValidates : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 身份认证Id1已认证
        /// </summary>
        [DisplayName("IdValidate")]
        public int IdValidate { get; set; }
        /// <summary>
        /// 身份认证日期
        /// </summary>
        [DisplayName("IdValidateDate")]
        public DateTime IdValidateDate { get; set; }
        /// <summary>
        /// 手机认证1已认证
        /// </summary>
        [DisplayName("PhoneValidate")]
        public int PhoneValidate { get; set; }
        /// <summary>
        /// 手机认证时间
        /// </summary>
        [DisplayName("PhoneValidateDate")]
        public DateTime PhoneValidateDate { get; set; }
        /// <summary>
        /// 视频认证1已认证
        /// </summary>
        [DisplayName("VideoValidate")]
        public int VideoValidate { get; set; }
        /// <summary>
        /// 视频认证时间
        /// </summary>
        [DisplayName("VideoValidateDate")]
        public DateTime VideoValidateDate { get; set; }
        /// <summary>
        /// 邮箱认证
        /// </summary>
        [DisplayName("EmailValidate")]
        public int EmailValidate { get; set; }
        /// <summary>
        /// 邮箱认证时间
        /// </summary>
        [DisplayName("EmailValidateDate")]
        public DateTime EmailValidateDate { get; set; }
        /// <summary>
        /// 学历认证
        /// </summary>
        [DisplayName("EducationValidate")]
        public int EducationValidate { get; set; }
        /// <summary>
        /// 学历认证时间
        /// </summary>
        [DisplayName("EducationValidateDate")]
        public DateTime EducationValidateDate { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

