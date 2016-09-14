using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ���ּ�¼��
    /// </summary>
    [Table("AccountWithDrawals")]
    public class AccountWithDrawals : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("WithDrawId")]
        [Key]
        public int WithDrawId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �����    ����̨�˺�Id��
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// �������ӦUserAccounts
        /// </summary>
        [DisplayName("UserAccountId")]
        public int UserAccountId { get; set; }
        /// <summary>
        /// ���ֽ��
        /// </summary>
        [DisplayName("WithDrawAmount")]
        public decimal WithDrawAmount { get; set; }
        /// <summary>
        /// 0�����  1ͨ��  2��ͨ�� 3���ִ����� 4���ֳɹ� 5����ʧ�� 6ɾ��
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��֤����
        /// </summary>
        [DisplayName("VerifiedDate")]
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// �������ֽ��
        /// </summary>
        [DisplayName("FinallyDrawAmount")]
        public decimal FinallyDrawAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// ʧ�ܻ�ͨ��ԭ��
        /// </summary>
        [DisplayName("Reason")]
        public String Reason { get; set; }
        /// <summary>
        /// ������ˮ��
        /// </summary>
        [DisplayName("DealingId")]
        public String DealingId { get; set; }
        /// <summary>
        /// ���κ�
        /// </summary>
        [DisplayName("BatchNo")]
        public String BatchNo { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

