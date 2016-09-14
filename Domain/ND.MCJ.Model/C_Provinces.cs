using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("C_Provinces")]
    public class C_Provinces : BaseModel
    {
        /// <summary>
        /// 
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
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("LastUpdateDate")]
        public DateTime LastUpdateDate { get; set; }
    }
}

