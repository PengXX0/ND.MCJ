using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �ڳ�ر���ʽ��
    /// </summary>
    [Table("RepayWays")]
    public class RepayWays : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("RepayId")]
        [Key]
        public int RepayId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ֧�ֽ��
        /// </summary>
        [DisplayName("SupportAmount")]
        public decimal SupportAmount { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// ͼƬ����ͼ���ŷָ�
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// 0ɾ�� 1�ȴ��ر�  2�ر��� 3�ѻر�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// �ûر���ʽ����֧�ֵ��������,������������0
        /// </summary>
        [DisplayName("MaxNumber")]
        public int MaxNumber { get; set; }
        /// <summary>
        /// �ûر���ʽ��ʼ�ر����������
        /// </summary>
        [DisplayName("RepayDays")]
        public int RepayDays { get; set; }
    }
}

