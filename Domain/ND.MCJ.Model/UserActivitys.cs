using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户活动表
    /// </summary>
    [Table("UserActivitys")]
    public class UserActivitys : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserActivityId")]
        [Key]
        public int UserActivityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Action")]
        public int Action { get; set; }
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
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

