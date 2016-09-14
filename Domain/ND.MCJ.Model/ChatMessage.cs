using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("ChatMessage")]
    public class ChatMessage : BaseModel
    {
        /// <summary>
        /// 主键 自增
        /// </summary>
        [DisplayName("MsgId")]
        [Key]
        public int MsgId { get; set; }
        /// <summary>
        /// 环信消息id
        /// </summary>
        [DisplayName("EasemobMsgId")]
        public String EasemobMsgId { get; set; }
        /// <summary>
        /// 发送人username
        /// </summary>
        [DisplayName("From")]
        public String From { get; set; }
        /// <summary>
        /// 接收人的username或者接收group的id
        /// </summary>
        [DisplayName("To")]
        public String To { get; set; }
        /// <summary>
        /// 用来判断单聊还是群聊。chat:单聊，groupchat:群聊
        /// </summary>
        [DisplayName("ChatType")]
        public String ChatType { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        [DisplayName("MsgContent")]
        public String MsgContent { get; set; }
        /// <summary>
        /// 消息类型。txt:文本消息, img:图片, loc：位置, audio：语音
        /// </summary>
        [DisplayName("MsgType")]
        public String MsgType { get; set; }
        /// <summary>
        /// 语音时长，单位为秒，这个属性只有语音消息有
        /// </summary>
        [DisplayName("Length")]
        public int Length { get; set; }
        /// <summary>
        /// 图片语音等文件的网络url，图片和语音消息有这个属性
        /// </summary>
        [DisplayName("Url")]
        public String Url { get; set; }
        /// <summary>
        /// 文件名字，图片和语音消息有这个属性
        /// </summary>
        [DisplayName("FileName")]
        public String FileName { get; set; }
        /// <summary>
        /// 获取文件的secret，图片和语音消息有这个属性
        /// </summary>
        [DisplayName("Secret")]
        public String Secret { get; set; }
        /// <summary>
        /// 发送的位置的纬度，只有位置消息有这个属性
        /// </summary>
        [DisplayName("Lat")]
        public decimal Lat { get; set; }
        /// <summary>
        /// 位置经度，只有位置消息有这个属性
        /// </summary>
        [DisplayName("Lng")]
        public decimal Lng { get; set; }
        /// <summary>
        /// 位置消息详细地址，只有位置消息有这个属性
        /// </summary>
        [DisplayName("addr")]
        public String addr { get; set; }
        /// <summary>
        /// 消息发送时间
        /// </summary>
        [DisplayName("Timestamp")]
        public String Timestamp { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        [DisplayName("Thumb")]
        public String Thumb { get; set; }
        /// <summary>
        /// 缩略图secret
        /// </summary>
        [DisplayName("ThumbSecret")]
        public String ThumbSecret { get; set; }
        /// <summary>
        /// 文件大小  byte长度  视频消息有这个属性
        /// </summary>
        [DisplayName("FileLength")]
        public int FileLength { get; set; }
        /// <summary>
        /// 接收人的username或者接收group的id
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

