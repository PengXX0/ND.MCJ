using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ��¼ÿ�ʽ��׺�ǰ�û����
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

