using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 好友关系表      （a-->b ,b-->a，保存两条）
    /// </summary>
    [Table("ChatFriendships")]
    public class ChatFriendships : BaseModel
    {
        /// <summary>
        /// 主键自增ID
        /// </summary>
        [DisplayName("FriendshipId")]
        [Key]
        public int FriendshipId { get; set; }
        /// <summary>
        /// 用户ID，好友关系中的host
        /// </summary>
        [DisplayName("OwnerId")]
        public int OwnerId { get; set; }
        /// <summary>
        /// 用户ID，好友关系中的Guest
        /// </summary>
        [DisplayName("FriendId")]
        public int FriendId { get; set; }
        /// <summary>
        /// 备注与标签
        /// </summary>
        [DisplayName("Notes")]
        public String Notes { get; set; }
        /// <summary>
        /// 不看他的动态，  0不看 1看
        /// </summary>
        [DisplayName("INotSeeHimId")]
        public int INotSeeHimId { get; set; }
        /// <summary>
        /// 不让他看我的动态，0不看  1看
        /// </summary>
        [DisplayName("HeNotSeeMeId")]
        public int HeNotSeeMeId { get; set; }
        /// <summary>
        /// 好友状态Id，  0 正常  1黑名单 2已删除 
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

