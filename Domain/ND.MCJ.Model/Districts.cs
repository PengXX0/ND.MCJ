using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 区县信息表
    /// </summary>
    [Table("Districts")]
    public class Districts : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("DistrictId")]
        [Key]
        public int DistrictId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("DistrictName")]
        public String DistrictName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CityId")]
        public int CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

