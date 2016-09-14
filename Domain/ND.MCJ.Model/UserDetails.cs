using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户详情表
    /// </summary>
    [Table("UserDetails")]
    public class UserDetails : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 0未知   1男  2女
        /// </summary>
        [DisplayName("Sex")]
        public int Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [DisplayName("Age")]
        public int Age { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [DisplayName("RealName")]
        public String RealName { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [DisplayName("IdNumber")]
        public String IdNumber { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        [DisplayName("Occupation")]
        public String Occupation { get; set; }
        /// <summary>
        /// 学校
        /// </summary>
        [DisplayName("School")]
        public String School { get; set; }
        /// <summary>
        /// 公司
        /// </summary>
        [DisplayName("Company")]
        public String Company { get; set; }
        /// <summary>
        /// 区县ID
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [DisplayName("Address")]
        public String Address { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

