using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("SYS_MethodPermissions")]
    public class SYS_MethodPermissions : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MethodPermissionId")]
        [Key]
        public int MethodPermissionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("MethodName")]
        public String MethodName { get; set; }
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
        [DisplayName("MethodType")]
        public int MethodType { get; set; }
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
    }
}

