using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 好友申请表
    /// </summary>
    [Table("ChatFriendApplications")]
    public class ChatFriendApplications : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("FriendApplyId")]
        [Key]
        public int FriendApplyId { get; set; }
        /// <summary>
        /// 0好友申请   1好友邀请
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 用户自己的Id
        /// </summary>
        [DisplayName("OwnerId")]
        public int OwnerId { get; set; }
        /// <summary>
        /// 要添加好友的Id
        /// </summary>
        [DisplayName("FriendId")]
        public int FriendId { get; set; }
        /// <summary>
        /// 手机    (如果是好友邀请就填写手机)
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 0申请中  1通过  2拒绝   3屏蔽
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

