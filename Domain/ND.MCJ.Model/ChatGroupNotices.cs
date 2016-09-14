using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// Ⱥ�����б�
    /// </summary>
    [Table("ChatGroupNotices")]
    public class ChatGroupNotices : BaseModel
    {
        /// <summary>
        /// Ⱥ����Id����������
        /// </summary>
        [DisplayName("GroupNoteId")]
        [Key]
        public int GroupNoteId { get; set; }
        /// <summary>
        /// ȺID
        /// </summary>
        [DisplayName("GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        [DisplayName("Title")]
        public String Title { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// 0��ɾ��  1����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �޸�����
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

