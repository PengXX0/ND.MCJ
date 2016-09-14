using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ��ֵ��¼��
    /// </summary>
    [Table("RechargeLogs")]
    public class RechargeLogs : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RechargeId")]
        [Key]
        public int RechargeId { get; set; }
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
        /// ��ֵ���
        /// </summary>
        [DisplayName("RechargeAmount")]
        public decimal RechargeAmount { get; set; }
        /// <summary>
        /// 0ʧ��  1�ɹ�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��֤����
        /// </summary>
        [DisplayName("VerifiedDate")]
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// ���ճ�ֵ���
        /// </summary>
        [DisplayName("FinallyRechargeAmount")]
        public decimal FinallyRechargeAmount { get; set; }
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
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

