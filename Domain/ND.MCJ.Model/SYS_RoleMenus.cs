using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_RoleMenus")]
    public class SYS_RoleMenus : BaseModel
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
        [DisplayName("MenuPermissionId")]
        [Key, Column(Order = 1)]
        public int MenuPermissionId { get; set; }
    }
}

