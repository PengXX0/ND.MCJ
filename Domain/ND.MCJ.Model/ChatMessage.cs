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
        /// ���� ����
        /// </summary>
        [DisplayName("MsgId")]
        [Key]
        public int MsgId { get; set; }
        /// <summary>
        /// ������Ϣid
        /// </summary>
        [DisplayName("EasemobMsgId")]
        public String EasemobMsgId { get; set; }
        /// <summary>
        /// ������username
        /// </summary>
        [DisplayName("From")]
        public String From { get; set; }
        /// <summary>
        /// �����˵�username���߽���group��id
        /// </summary>
        [DisplayName("To")]
        public String To { get; set; }
        /// <summary>
        /// �����жϵ��Ļ���Ⱥ�ġ�chat:���ģ�groupchat:Ⱥ��
        /// </summary>
        [DisplayName("ChatType")]
        public String ChatType { get; set; }
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        [DisplayName("MsgContent")]
        public String MsgContent { get; set; }
        /// <summary>
        /// ��Ϣ���͡�txt:�ı���Ϣ, img:ͼƬ, loc��λ��, audio������
        /// </summary>
        [DisplayName("MsgType")]
        public String MsgType { get; set; }
        /// <summary>
        /// ����ʱ������λΪ�룬�������ֻ��������Ϣ��
        /// </summary>
        [DisplayName("Length")]
        public int Length { get; set; }
        /// <summary>
        /// ͼƬ�������ļ�������url��ͼƬ��������Ϣ���������
        /// </summary>
        [DisplayName("Url")]
        public String Url { get; set; }
        /// <summary>
        /// �ļ����֣�ͼƬ��������Ϣ���������
        /// </summary>
        [DisplayName("FileName")]
        public String FileName { get; set; }
        /// <summary>
        /// ��ȡ�ļ���secret��ͼƬ��������Ϣ���������
        /// </summary>
        [DisplayName("Secret")]
        public String Secret { get; set; }
        /// <summary>
        /// ���͵�λ�õ�γ�ȣ�ֻ��λ����Ϣ���������
        /// </summary>
        [DisplayName("Lat")]
        public decimal Lat { get; set; }
        /// <summary>
        /// λ�þ��ȣ�ֻ��λ����Ϣ���������
        /// </summary>
        [DisplayName("Lng")]
        public decimal Lng { get; set; }
        /// <summary>
        /// λ����Ϣ��ϸ��ַ��ֻ��λ����Ϣ���������
        /// </summary>
        [DisplayName("addr")]
        public String addr { get; set; }
        /// <summary>
        /// ��Ϣ����ʱ��
        /// </summary>
        [DisplayName("Timestamp")]
        public String Timestamp { get; set; }
        /// <summary>
        /// ����ͼ
        /// </summary>
        [DisplayName("Thumb")]
        public String Thumb { get; set; }
        /// <summary>
        /// ����ͼsecret
        /// </summary>
        [DisplayName("ThumbSecret")]
        public String ThumbSecret { get; set; }
        /// <summary>
        /// �ļ���С  byte����  ��Ƶ��Ϣ���������
        /// </summary>
        [DisplayName("FileLength")]
        public int FileLength { get; set; }
        /// <summary>
        /// �����˵�username���߽���group��id
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

