using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 手机验证码
    /// </summary>
    [Table("MobileCodes")]
    public class MobileCodes : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("MobileCodeId")]
        [Key]
        public int MobileCodeId { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        [DisplayName("Code")]
        public String Code { get; set; }
        /// <summary>
        /// 验证码类型：1注册
        /// </summary>
        [DisplayName("CodeTypeId")]
        public int CodeTypeId { get; set; }
        /// <summary>
        /// 状态：0未使用，1已使用，2过期
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

