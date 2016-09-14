using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 省 记录表
    /// </summary>
    [Table("Provinces")]
    public class Provinces : BaseModel
    {
        /// <summary>
        /// 主键  省id
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

