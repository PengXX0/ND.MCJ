using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("AdminActivitys")]
    public class AdminActivitys : BaseModel
    {
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("AdminActivityId")]
        [Key]
        public int AdminActivityId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// �������û�
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ��Ӧö��AdminUserEventType
        /// </summary>
        [DisplayName("EventTypeId")]
        public int EventTypeId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        [DisplayName("Others")]
        public String Others { get; set; }
        /// <summary>
        /// IP��ַ
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

