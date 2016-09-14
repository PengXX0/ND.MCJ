using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_Users")]
    public class SYS_Users : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("LoginName")]
        public String LoginName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("PassWord")]
        public String PassWord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RealName")]
        public String RealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoleId")]
        public int RoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

