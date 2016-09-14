using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �����б�
    /// </summary>
    [Table("Citys")]
    public class Citys : BaseModel
    {
        /// <summary>
        /// ����ID
        /// </summary>
        [DisplayName("CityId")]
        [Key]
        public int CityId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CityName")]
        public String CityName { get; set; }
        /// <summary>
        /// �ʱ�
        /// </summary>
        [DisplayName("ZipCode")]
        public String ZipCode { get; set; }
        /// <summary>
        /// ����ʡID
        /// </summary>
        [DisplayName("ProvinceId")]
        public int ProvinceId { get; set; }
        /// <summary>
        /// ƴ��
        /// </summary>
        [DisplayName("PinYin")]
        public String PinYin { get; set; }
        /// <summary>
        /// ��д
        /// </summary>
        [DisplayName("Logogram")]
        public String Logogram { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

