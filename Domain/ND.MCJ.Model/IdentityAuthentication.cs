using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 身份认证信息表
    /// </summary>
    [Table("IdentityAuthentication")]
    public class IdentityAuthentication : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IdentiAuthId")]
        [Key]
        public int IdentiAuthId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
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
        /// 0不通过  1通过
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

