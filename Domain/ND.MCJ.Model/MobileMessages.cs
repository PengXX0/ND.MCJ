using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ������Ϣ��
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
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// ���ͣ�Ҳ�������ȼ���
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Contents")]
        public String Contents { get; set; }
        /// <summary>
        /// �Ƿ��ѷ���
        /// </summary>
        [DisplayName("IsSend")]
        public int IsSend { get; set; }
        /// <summary>
        /// �Ƿ�ʱ����
        /// </summary>
        [DisplayName("IsTimely")]
        public int IsTimely { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        [DisplayName("SmsTypeId")]
        public int SmsTypeId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("ReplyCode")]
        public String ReplyCode { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

