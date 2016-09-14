using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û���¼��־��
    /// </summary>
    [Table("UserLoginLog")]
    public class UserLoginLog : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("LoginId")]
        [Key]
        public int LoginId { get; set; }
        /// <summary>
        /// �ֻ���
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// �û���������
        /// </summary>
        [DisplayName("Password")]
        public int Password { get; set; }
        /// <summary>
        /// 0��¼ʧ��   1��¼�ɹ�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public int CreateDate { get; set; }
    }
}

