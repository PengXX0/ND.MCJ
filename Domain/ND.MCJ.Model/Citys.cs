using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 城市列表
    /// </summary>
    [Table("Citys")]
    public class Citys : BaseModel
    {
        /// <summary>
        /// 城市ID
        /// </summary>
        [DisplayName("CityId")]
        [Key]
        public int CityId { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        [DisplayName("CityName")]
        public String CityName { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [DisplayName("ZipCode")]
        public String ZipCode { get; set; }
        /// <summary>
        /// 所属省ID
        /// </summary>
        [DisplayName("ProvinceId")]
        public int ProvinceId { get; set; }
        /// <summary>
        /// 拼音
        /// </summary>
        [DisplayName("PinYin")]
        public String PinYin { get; set; }
        /// <summary>
        /// 简写
        /// </summary>
        [DisplayName("Logogram")]
        public String Logogram { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

