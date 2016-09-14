using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �ٱ��б�   �ٱ��û���Ⱥ�б�   (�û����ٱ��Ժ��Զ����������)
    /// </summary>
    [Table("ReportLists")]
    public class ReportLists : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ReportId")]
        [Key]
        public int ReportId { get; set; }
        /// <summary>
        /// �ٱ���
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �ٱ�����  0Ⱥ  1�û�
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// ���ٱ�����   �����Ǳ��ٱ��û�Id    Ҳ������ȺId
        /// </summary>
        [DisplayName("ObjectId")]
        public int ObjectId { get; set; }
        /// <summary>
        /// ԭ��
        /// </summary>
        [DisplayName("Reason")]
        public String Reason { get; set; }
        /// <summary>
        /// 0�����  1��ͨ��  2ͨ��
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

