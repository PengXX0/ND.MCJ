using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ��̨ҵ����Ա��Ϊ��¼����Ҫ��¼��һЩ��Ϊ��־
    /// </summary>
    [Table("SYS_AdminActivitys")]
    public class SYS_AdminActivitys : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AdminActivityId")]
        [Key]
        public int AdminActivityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AdminUserId")]
        public int AdminUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("EventTypeId")]
        public int EventTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Others")]
        public String Others { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

