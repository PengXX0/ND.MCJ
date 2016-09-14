using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ʡ ��¼��
    /// </summary>
    [Table("Provinces")]
    public class Provinces : BaseModel
    {
        /// <summary>
        /// ����  ʡid
        /// </summary>
        [DisplayName("ProvinceId")]
        [Key]
        public int ProvinceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ProvinceName")]
        public String ProvinceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OrderId")]
        public int OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

