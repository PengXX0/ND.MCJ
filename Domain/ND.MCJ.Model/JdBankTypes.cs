using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("JdBankTypes")]
    public class JdBankTypes : BaseModel
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
        [DisplayName("BankCode")]
        public String BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BankName")]
        public String BankName { get; set; }
    }
}

