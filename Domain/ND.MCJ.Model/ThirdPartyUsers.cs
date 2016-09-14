using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 第三方注册用户表
    /// </summary>
    [Table("ThirdPartyUsers")]
    public class ThirdPartyUsers : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("TPUserId")]
        [Key]
        public int TPUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 账号类型  0微博  1微信  2QQ
        /// </summary>
        [DisplayName("Type")]
        public int Type { get; set; }
        /// <summary>
        /// 第三方应用提供的Id
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// 0未知  1男  2女
        /// </summary>
        [DisplayName("Sex")]
        public int Sex { get; set; }
        /// <summary>
        /// 所在省
        /// </summary>
        [DisplayName("Province")]
        public String Province { get; set; }
        /// <summary>
        /// 所在城市
        /// </summary>
        [DisplayName("City")]
        public String City { get; set; }
        /// <summary>
        /// 图像地址
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 微信的OpenId, 微信公众号添加多应用,OpenId不唯一，UnionId与OpenId保存入库时互换
        /// </summary>
        [DisplayName("UnionId")]
        public String UnionId { get; set; }
    }
}

