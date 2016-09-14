using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SystemWithdrawLogs")]
    public class SystemWithdrawLogs : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysWithdrawLogId")]
        [Key]
        public int SysWithdrawLogId { get; set; }
        /// <summary>
        /// ���κ�
        /// </summary>
        [DisplayName("BatchNo")]
        public String BatchNo { get; set; }
        /// <summary>
        /// ֪ͨʱ��
        /// </summary>
        [DisplayName("NotifyTime")]
        public DateTime NotifyTime { get; set; }
        /// <summary>
        /// ֪ͨ����
        /// </summary>
        [DisplayName("NotifyType")]
        public String NotifyType { get; set; }
        /// <summary>
        /// ֪ͨId
        /// </summary>
        [DisplayName("NotifyId")]
        public String NotifyId { get; set; }
        /// <summary>
        /// ǩ������
        /// </summary>
        [DisplayName("SignType")]
        public String SignType { get; set; }
        /// <summary>
        /// ǩ��
        /// </summary>
        [DisplayName("Sign")]
        public String Sign { get; set; }
        /// <summary>
        /// �����˺�ID
        /// </summary>
        [DisplayName("PayUserId")]
        public String PayUserId { get; set; }
        /// <summary>
        /// �����˺�����
        /// </summary>
        [DisplayName("PayUserName")]
        public String PayUserName { get; set; }
        /// <summary>
        /// �����˺�
        /// </summary>
        [DisplayName("PayAccountNo")]
        public String PayAccountNo { get; set; }
        /// <summary>
        /// ת�˳ɹ�����ϸ��Ϣ
        /// </summary>
        [DisplayName("SuccessDetails")]
        public String SuccessDetails { get; set; }
        /// <summary>
        /// ת��ʧ�ܵ���ϸ��Ϣ
        /// </summary>
        [DisplayName("FailDetails")]
        public String FailDetails { get; set; }
    }
}

