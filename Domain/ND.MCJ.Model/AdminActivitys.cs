using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("AdminActivitys")]
    public class AdminActivitys : BaseModel
    {
        /// <summary>
        /// 自增列
        /// </summary>
        [DisplayName("AdminActivityId")]
        [Key]
        public int AdminActivityId { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// 被操作用户
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 对应枚举AdminUserEventType
        /// </summary>
        [DisplayName("EventTypeId")]
        public int EventTypeId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// 其他信息
        /// </summary>
        [DisplayName("Others")]
        public String Others { get; set; }
        /// <summary>
        /// IP地址
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

