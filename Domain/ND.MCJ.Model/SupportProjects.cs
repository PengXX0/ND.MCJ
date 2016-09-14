using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û�֧�ֵ���Ŀ�б�
    /// </summary>
    [Table("SupportProjects")]
    public class SupportProjects : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("SupportProjectId")]
        [Key]
        public int SupportProjectId { get; set; }
        /// <summary>
        /// ֧����
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ��ĿID
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// �ر�ID
        /// </summary>
        [DisplayName("RepayId")]
        public int RepayId { get; set; }
        /// <summary>
        /// Ͷ�ʽ��
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 0���ر�  1�ر���  2�ѻر�  3��ʧ��  4��ɾ��
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �û���ַId
        /// </summary>
        [DisplayName("UserAddresId")]
        public int UserAddresId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// �û�֧�����״̬ 0δ���� 1�ѵ���
        /// </summary>
        [DisplayName("AmountStatusId")]
        public int AmountStatusId { get; set; }
        /// <summary>
        /// ֧������Id
        /// </summary>
        [DisplayName("PayTypeId")]
        public int PayTypeId { get; set; }
        /// <summary>
        /// ��ע������֧����Ŀʱ��д��������Ϣ
        /// </summary>
        [DisplayName("Remark")]
        public String Remark { get; set; }
    }
}

