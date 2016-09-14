using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ϵͳ��̬��Ϣ   �û�֧����Ŀ����Ϣ
    /// </summary>
    [Table("SystemMessages")]
    public class SystemMessages : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("SysMsgId")]
        [Key]
        public int SysMsgId { get; set; }
        /// <summary>
        /// ��Ϣ������
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ��Ϣ����ID   �������ڳ���ĿId
        /// </summary>
        [DisplayName("AboutId")]
        public String AboutId { get; set; }
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        [DisplayName("Message")]
        public String Message { get; set; }
        /// <summary>
        /// 0ɾ��  1δ��2�Ѷ�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ���ͣ�0ϵͳ��Ϣ1������Ϣ
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// ���Ͷ���0Ĭ�� 1���а�װ�û� 2����ע���û� 3������ĿͶ���û� 4�����û�
        /// </summary>
        [DisplayName("PushId")]
        public int PushId { get; set; }
        /// <summary>
        /// ������Id
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

