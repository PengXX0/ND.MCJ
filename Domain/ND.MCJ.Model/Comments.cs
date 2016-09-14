using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ������Ϣ����¼�û����ڳ�ĸ�������
    /// </summary>
    [Table("Comments")]
    public class Comments : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CommentId")]
        [Key]
        public int CommentId { get; set; }
        /// <summary>
        /// �ڳ���ĿId
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// ���۵���
        /// </summary>
        [DisplayName("CommentUserId")]
        public int CommentUserId { get; set; }
        /// <summary>
        /// �ظ�����
        /// </summary>
        [DisplayName("ReplyUserId")]
        public int ReplyUserId { get; set; }
        /// <summary>
        /// ���۵���Ϣ
        /// </summary>
        [DisplayName("CommentMsg")]
        public String CommentMsg { get; set; }
        /// <summary>
        /// �ظ�����Ϣ
        /// </summary>
        [DisplayName("ReplyMsg")]
        public String ReplyMsg { get; set; }
        /// <summary>
        /// 0ɾ�� 1����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �ظ�ʱ������
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

