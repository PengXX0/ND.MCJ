using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 记录每笔交易后当前用户金额
    /// </summary>
    [Table("NewBalance")]
    public class NewBalance : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AccountDetailId")]
        [Key]
        public int AccountDetailId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

