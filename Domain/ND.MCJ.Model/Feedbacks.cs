using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ������¼��
    /// </summary>
    [Table("Feedbacks")]
    public class Feedbacks : BaseModel
    {
        /// <summary>
        /// ��������  ����ID
        /// </summary>
        [DisplayName("FeedbackId")]
        [Key]
        public int FeedbackId { get; set; }
        /// <summary>
        /// �������û���
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// �ظ���ID
        /// </summary>
        [DisplayName("ReplyUserId")]
        public int ReplyUserId { get; set; }
        /// <summary>
        /// �ظ���������
        /// </summary>
        [DisplayName("ReplyContent")]
        public String ReplyContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 0δ�ظ�1�ѻظ�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

