using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_ButtonPermissions")]
    public class SYS_ButtonPermissions : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ButtonPermissionId")]
        [Key]
        public int ButtonPermissionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MethodPermissionId")]
        public int MethodPermissionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ButtonKey")]
        public String ButtonKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ButtonValue")]
        public String ButtonValue { get; set; }
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

