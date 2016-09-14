using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 众筹回报方式表
    /// </summary>
    [Table("RepayWays")]
    public class RepayWays : BaseModel
    {
        /// <summary>
        /// 主键自增
        /// </summary>
        [DisplayName("RepayId")]
        [Key]
        public int RepayId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 支持金额
        /// </summary>
        [DisplayName("SupportAmount")]
        public decimal SupportAmount { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// 图片，多图逗号分割
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// 0删除 1等待回报  2回报中 3已回报
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 该回报方式允许支持的最大人数,若不限制则填0
        /// </summary>
        [DisplayName("MaxNumber")]
        public int MaxNumber { get; set; }
        /// <summary>
        /// 该回报方式开始回报的最大期限
        /// </summary>
        [DisplayName("RepayDays")]
        public int RepayDays { get; set; }
    }
}

