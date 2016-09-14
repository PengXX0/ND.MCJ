using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �ڳ���Ŀ��
    /// </summary>
    [Table("CrowdFundings")]
    public class CrowdFundings : BaseModel
    {
        /// <summary>
        /// �ڳ���ĿId������
        /// </summary>
        [DisplayName("CrowdFundId")]
        [Key]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �ڳ�����
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// Ŀ����/���ʽ���
        /// </summary>
        [DisplayName("TargetAmount")]
        public decimal TargetAmount { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        [DisplayName("Profile")]
        public String Profile { get; set; }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// ����,��λ����
        /// </summary>
        [DisplayName("DueDays")]
        public int DueDays { get; set; }
        /// <summary>
        /// ͼƬ��ַ������ͼƬ���ŷָ�
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// ��Ƶ
        /// </summary>
        [DisplayName("Audios")]
        public String Audios { get; set; }
        /// <summary>
        /// �ѳ���
        /// </summary>
        [DisplayName("RaisedAmount")]
        public decimal RaisedAmount { get; set; }
        /// <summary>
        /// ���ȣ�0������ 1�������  2�ر���  3����(�ɹ�)  4�ѳ���  5ʧ�� 6���ã�������Ͷ�ʣ�7ɾ�� 
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �ڳ�����Id   Ĭ��0
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// Ĭ��Ϊ0���Ƽ���  1�Ƽ�
        /// </summary>
        [DisplayName("RecommendSort")]
        public int RecommendSort { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// ��Ŀ���ܵ�html���ݣ�H5ר��
        /// </summary>
        [DisplayName("HtmlDescription")]
        public String HtmlDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AddContent")]
        public String AddContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AddHtmlDescription")]
        public String AddHtmlDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UpdateDate")]
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// ��Ŀ�ɹ����ϵͳ��ȡ��������
        /// </summary>
        [DisplayName("Poundage")]
        public decimal Poundage { get; set; }
        /// <summary>
        /// ��Ŀ�ɹ���ʱ��
        /// </summary>
        [DisplayName("SucDate")]
        public DateTime SucDate { get; set; }
    }
}

