using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 评论信息表，记录用户对众筹的各种评论
    /// </summary>
    [Table("Comments")]
    public class Comments : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("CommentId")]
        [Key]
        public int CommentId { get; set; }
        /// <summary>
        /// 众筹项目Id
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 评论的人
        /// </summary>
        [DisplayName("CommentUserId")]
        public int CommentUserId { get; set; }
        /// <summary>
        /// 回复的人
        /// </summary>
        [DisplayName("ReplyUserId")]
        public int ReplyUserId { get; set; }
        /// <summary>
        /// 评论的信息
        /// </summary>
        [DisplayName("CommentMsg")]
        public String CommentMsg { get; set; }
        /// <summary>
        /// 回复的信息
        /// </summary>
        [DisplayName("ReplyMsg")]
        public String ReplyMsg { get; set; }
        /// <summary>
        /// 0删除 1正常
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 回复时间日期
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

