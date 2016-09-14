using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ���������ñ�
    /// </summary>
    [Table("ThirdpartyConfig")]
    public class ThirdpartyConfig : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Id")]
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("FromEmail")]
        public String FromEmail { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("MailServer")]
        public String MailServer { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        [DisplayName("MailUserName")]
        public String MailUserName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("MailPassword")]
        public String MailPassword { get; set; }
        /// <summary>
        /// �˿ں�
        /// </summary>
        [DisplayName("MailPort")]
        public int MailPort { get; set; }
        /// <summary>
        /// ���Ź�Ӧ��
        /// </summary>
        [DisplayName("SmsSuppliers")]
        public String SmsSuppliers { get; set; }
        /// <summary>
        /// �����û���
        /// </summary>
        [DisplayName("SmsUserName")]
        public String SmsUserName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("SmsPassword")]
        public String SmsPassword { get; set; }
        /// <summary>
        /// ��ҵId
        /// </summary>
        [DisplayName("EnterpriseId")]
        public int EnterpriseId { get; set; }
    }
}

