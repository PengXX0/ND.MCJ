using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 消息推送设置
    /// </summary>
    [Table("MessageSetting")]
    public class MessageSetting : BaseModel
    {
        /// <summary>
        /// 用户名为主键
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 是否显示通知消息详情   0不显示   1显示
        /// </summary>
        [DisplayName("IsShowDetails")]
        public int IsShowDetails { get; set; }
        /// <summary>
        /// 消息免打扰      0开启      1夜间开启      2关闭
        /// </summary>
        [DisplayName("MsgTrouble")]
        public int MsgTrouble { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

