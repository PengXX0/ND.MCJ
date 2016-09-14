using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("BankTypes")]
    public class BankTypes : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankTypeId")]
        [Key]
        public int BankTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankName")]
        public String BankName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OrderId")]
        public int OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IsDisplay")]
        public int IsDisplay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankCode")]
        public String BankCode { get; set; }
    }
}

