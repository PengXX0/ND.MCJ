using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �绰ͨѶ¼�б�
    /// </summary>
    [Table("PhoneNums")]
    public class PhoneNums : BaseModel
    {
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("PhoneId")]
        [Key]
        public int PhoneId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �绰�����ߵ�����
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// �绰����
        /// </summary>
        [DisplayName("Phone")]
        public String Phone { get; set; }
        /// <summary>
        /// 0ɾ�� 1����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
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

