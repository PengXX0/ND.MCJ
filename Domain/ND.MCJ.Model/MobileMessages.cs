using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 短信信息表
    /// </summary>
    [Table("MobileMessages")]
    public class MobileMessages : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MobileMsgId")]
        [Key]
        public int MobileMsgId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 类型，也用于优先级别
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("Contents")]
        public String Contents { get; set; }
        /// <summary>
        /// 是否已发送
        /// </summary>
        [DisplayName("IsSend")]
        public int IsSend { get; set; }
        /// <summary>
        /// 是否即时发送
        /// </summary>
        [DisplayName("IsTimely")]
        public int IsTimely { get; set; }
        /// <summary>
        /// 短信类型ID
        /// </summary>
        [DisplayName("SmsTypeId")]
        public int SmsTypeId { get; set; }
        /// <summary>
        /// 返回码
        /// </summary>
        [DisplayName("ReplyCode")]
        public String ReplyCode { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

