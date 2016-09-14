using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("BankBranchs")]
    public class BankBranchs : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankBranchId")]
        [Key]
        public int BankBranchId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ProvinceId")]
        public int ProvinceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankTypeId")]
        public int BankTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BranchCode")]
        public double BranchCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BranchName")]
        public String BranchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CityId")]
        public int CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

