using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("TempCrowdFundingFailed")]
    public class TempCrowdFundingFailed : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("pageNum")]
        public long pageNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
    }
}

