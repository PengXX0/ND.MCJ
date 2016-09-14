using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ϵͳ�˻�
    /// </summary>
    [Table("SystemUsers")]
    public class SystemUsers : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("SysUserId")]
        [Key]
        public int SysUserId { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// 0 ����  1 ֧��
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// ״̬��0����  1����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

