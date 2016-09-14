using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("C_Citys")]
    public class C_Citys : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CityID")]
        [Key]
        public int CityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CityName")]
        public String CityName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ProvinceId")]
        public int ProvinceId { get; set; }
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

