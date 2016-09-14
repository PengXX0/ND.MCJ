using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 群用户列表
    /// </summary>
    [Table("ChatGroupUsers")]
    public class ChatGroupUsers : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("GruopUserId")]
        [Key]
        public int GruopUserId { get; set; }
        /// <summary>
        /// 群ID，
        /// </summary>
        [DisplayName("GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 用户在群中的昵称
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// 0已退群 1正常
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

