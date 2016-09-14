using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_Roles")]
    public class SYS_Roles : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoleId")]
        [Key]
        public int RoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoleName")]
        public String RoleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Describe")]
        public String Describe { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AuditTypeId")]
        public int AuditTypeId { get; set; }
    }
}

