using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_RoleButtons")]
    public class SYS_RoleButtons : BaseModel
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
        [DisplayName("ButtonPermissionId")]
        public int ButtonPermissionId { get; set; }
    }
}

