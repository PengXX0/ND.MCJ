using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("InpourOnlineDetails")]
    public class InpourOnlineDetails : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OnlineDetailId")]
        [Key]
        public int OnlineDetailId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OnlineId")]
        public int OnlineId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Property")]
        public String Property { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Value")]
        public String Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

