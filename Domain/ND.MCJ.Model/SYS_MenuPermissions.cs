using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_MenuPermissions")]
    public class SYS_MenuPermissions : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MenuPermissionId")]
        [Key]
        public int MenuPermissionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ParentId")]
        public int ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Url")]
        public String Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MenuName")]
        public String MenuName { get; set; }
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
        [DisplayName("OrderId")]
        public int OrderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ControllerName")]
        public String ControllerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

