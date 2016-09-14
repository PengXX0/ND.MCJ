using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �����޸ļ�¼
    /// </summary>
    [Table("PasswordChangeLog")]
    public class PasswordChangeLog : BaseModel
    {
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("PwdLogId")]
        [Key]
        public int PwdLogId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// ԭ����
        /// </summary>
        [DisplayName("OldPwd")]
        public String OldPwd { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("NewPwd")]
        public String NewPwd { get; set; }
        /// <summary>
        /// IP
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

