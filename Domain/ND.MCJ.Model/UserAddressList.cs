using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û���ַ�б�
    /// </summary>
    [Table("UserAddressList")]
    public class UserAddressList : BaseModel
    {
        /// <summary>
        /// ����  
        /// </summary>
        [DisplayName("UserAddresId")]
        [Key]
        public int UserAddresId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public String UserId { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RecvName")]
        public String RecvName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// ��ַ����
        /// </summary>
        [DisplayName("Details")]
        public String Details { get; set; }
        /// <summary>
        /// �ʱ�
        /// </summary>
        [DisplayName("ZipCode")]
        public String ZipCode { get; set; }
        /// <summary>
        /// 0��ɾ��  1���� 2Ĭ���ջ���ַ
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

