using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û��˻����飬�û��˵�
    /// </summary>
    [Table("AccountDetails")]
    public class AccountDetails : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("AccountDetailId")]
        [Key]
        public int AccountDetailId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �������ͣ�����ο�ö��MoneyEventType
        /// </summary>
        [DisplayName("EventType")]
        public int EventType { get; set; }
        /// <summary>
        /// ���׽��
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// ���˱ʽ��׼�¼������Id
        /// </summary>
        [DisplayName("AboutId")]
        public String AboutId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

