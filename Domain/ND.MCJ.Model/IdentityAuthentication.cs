using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �����֤��Ϣ��
    /// </summary>
    [Table("IdentityAuthentication")]
    public class IdentityAuthentication : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IdentiAuthId")]
        [Key]
        public int IdentiAuthId { get; set; }
        /// <summary>
        /// �û�ID
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ��ʵ����
        /// </summary>
        [DisplayName("RealName")]
        public String RealName { get; set; }
        /// <summary>
        /// ���֤��
        /// </summary>
        [DisplayName("IdNumber")]
        public String IdNumber { get; set; }
        /// <summary>
        /// 0��ͨ��  1ͨ��
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

