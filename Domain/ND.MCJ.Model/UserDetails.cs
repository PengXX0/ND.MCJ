using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û������
    /// </summary>
    [Table("UserDetails")]
    public class UserDetails : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 0δ֪   1��  2Ů
        /// </summary>
        [DisplayName("Sex")]
        public int Sex { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Age")]
        public int Age { get; set; }
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
        /// ְҵ
        /// </summary>
        [DisplayName("Occupation")]
        public String Occupation { get; set; }
        /// <summary>
        /// ѧУ
        /// </summary>
        [DisplayName("School")]
        public String School { get; set; }
        /// <summary>
        /// ��˾
        /// </summary>
        [DisplayName("Company")]
        public String Company { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// ��ϸ��ַ
        /// </summary>
        [DisplayName("Address")]
        public String Address { get; set; }
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

