using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 反馈记录表
    /// </summary>
    [Table("Feedbacks")]
    public class Feedbacks : BaseModel
    {
        /// <summary>
        /// 反馈主键  自增ID
        /// </summary>
        [DisplayName("FeedbackId")]
        [Key]
        public int FeedbackId { get; set; }
        /// <summary>
        /// 反馈人用户名
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 反馈内容
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// 回复人ID
        /// </summary>
        [DisplayName("ReplyUserId")]
        public int ReplyUserId { get; set; }
        /// <summary>
        /// 回复反馈内容
        /// </summary>
        [DisplayName("ReplyContent")]
        public String ReplyContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 0未回复1已回复
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

