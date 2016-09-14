using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û���Ϣ��
    /// </summary>
    [Table("Users")]
    public class Users : BaseModel
    {
        /// <summary>
        /// �û�Id������
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// �û���,
        /// </summary>
        [DisplayName("UserName")]
        public String UserName { get; set; }
        /// <summary>
        /// �ǳ�
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// ͼ��
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// ����ǩ��
        /// </summary>
        [DisplayName("Signature")]
        public String Signature { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Password")]
        public String Password { get; set; }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// �����ʼ�
        /// </summary>
        [DisplayName("Email")]
        public String Email { get; set; }
        /// <summary>
        /// ״̬��0����  1������  2����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��Դ��1App 2Android 3H5
        /// </summary>
        [DisplayName("FromId")]
        public int FromId { get; set; }
        /// <summary>
        /// �ϴε�¼ʱ��
        /// </summary>
        [DisplayName("LastLoginDate")]
        public DateTime LastLoginDate { get; set; }
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// �Ƿ��Ǻ����� 0�� 1��
        /// </summary>
        [DisplayName("IsBlackList")]
        public int IsBlackList { get; set; }
        /// <summary>
        /// ����Id 0�����˺�  1Ӫ���˺�
        /// </summary>
        [DisplayName("TypeId")]
        public int? TypeId { get; set; }
    }
}

