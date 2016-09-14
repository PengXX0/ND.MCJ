using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 系统动态信息   用户支持项目的信息
    /// </summary>
    [Table("SystemMessages")]
    public class SystemMessages : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("SysMsgId")]
        [Key]
        public int SysMsgId { get; set; }
        /// <summary>
        /// 消息接受人
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 消息关联ID   可能是众筹项目Id
        /// </summary>
        [DisplayName("AboutId")]
        public String AboutId { get; set; }
        /// <summary>
        /// 信息内容
        /// </summary>
        [DisplayName("Message")]
        public String Message { get; set; }
        /// <summary>
        /// 0删除  1未读2已读
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 类型：0系统消息1推送消息
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 发送对象：0默认 1所有安装用户 2所有注册用户 3单个项目投资用户 4单个用户
        /// </summary>
        [DisplayName("PushId")]
        public int PushId { get; set; }
        /// <summary>
        /// 发送人Id
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

