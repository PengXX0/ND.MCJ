using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// Ⱥ�û��б�
    /// </summary>
    [Table("ChatGroupUsers")]
    public class ChatGroupUsers : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("GruopUserId")]
        [Key]
        public int GruopUserId { get; set; }
        /// <summary>
        /// ȺID��
        /// </summary>
        [DisplayName("GroupId")]
        public int GroupId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �û���Ⱥ�е��ǳ�
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// 0����Ⱥ 1����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

