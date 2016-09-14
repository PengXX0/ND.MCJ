using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_RoleMethods")]
    public class SYS_RoleMethods : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RoleId")]
        [Key, Column(Order = 0)]
        public int RoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MethodPermissionId")]
        [Key, Column(Order = 1)]
        public int MethodPermissionId { get; set; }
    }
}

