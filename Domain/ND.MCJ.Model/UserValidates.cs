using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û���֤��Ϣ��
    /// </summary>
    [Table("UserValidates")]
    public class UserValidates : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// �����֤Id1����֤
        /// </summary>
        [DisplayName("IdValidate")]
        public int IdValidate { get; set; }
        /// <summary>
        /// �����֤����
        /// </summary>
        [DisplayName("IdValidateDate")]
        public DateTime IdValidateDate { get; set; }
        /// <summary>
        /// �ֻ���֤1����֤
        /// </summary>
        [DisplayName("PhoneValidate")]
        public int PhoneValidate { get; set; }
        /// <summary>
        /// �ֻ���֤ʱ��
        /// </summary>
        [DisplayName("PhoneValidateDate")]
        public DateTime PhoneValidateDate { get; set; }
        /// <summary>
        /// ��Ƶ��֤1����֤
        /// </summary>
        [DisplayName("VideoValidate")]
        public int VideoValidate { get; set; }
        /// <summary>
        /// ��Ƶ��֤ʱ��
        /// </summary>
        [DisplayName("VideoValidateDate")]
        public DateTime VideoValidateDate { get; set; }
        /// <summary>
        /// ������֤
        /// </summary>
        [DisplayName("EmailValidate")]
        public int EmailValidate { get; set; }
        /// <summary>
        /// ������֤ʱ��
        /// </summary>
        [DisplayName("EmailValidateDate")]
        public DateTime EmailValidateDate { get; set; }
        /// <summary>
        /// ѧ����֤
        /// </summary>
        [DisplayName("EducationValidate")]
        public int EducationValidate { get; set; }
        /// <summary>
        /// ѧ����֤ʱ��
        /// </summary>
        [DisplayName("EducationValidateDate")]
        public DateTime EducationValidateDate { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

