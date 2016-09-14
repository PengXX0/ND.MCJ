using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 群公告列表
    /// </summary>
    [Table("ChatGroupNotices")]
    public class ChatGroupNotices : BaseModel
    {
        /// <summary>
        /// 群公告Id，自增主键
        /// </summary>
        [DisplayName("GroupNoteId")]
        [Key]
        public int GroupNoteId { get; set; }
        /// <summary>
        /// 群ID
        /// </summary>
        [DisplayName("GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// 公告标题
        /// </summary>
        [DisplayName("Title")]
        public String Title { get; set; }
        /// <summary>
        /// 公告内容
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// 0已删除  1正常
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 修改日期
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

