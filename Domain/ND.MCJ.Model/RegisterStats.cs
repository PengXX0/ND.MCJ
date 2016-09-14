using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("RegisterStats")]
    public class RegisterStats : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Id")]
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 当日新增注册数
        /// </summary>
        [DisplayName("DayRegCount")]
        public int DayRegCount { get; set; }
        /// <summary>
        /// 累计注册数
        /// </summary>
        [DisplayName("RegCount")]
        public int RegCount { get; set; }
        /// <summary>
        /// 新增发起项目人数
        /// </summary>
        [DisplayName("NewLaunchCount")]
        public int NewLaunchCount { get; set; }
        /// <summary>
        /// 当日总发起项目人数
        /// </summary>
        [DisplayName("DayLaunchCount")]
        public int DayLaunchCount { get; set; }
        /// <summary>
        /// 累计发起项目人数
        /// </summary>
        [DisplayName("LaunchCount")]
        public int LaunchCount { get; set; }
        /// <summary>
        /// 新增投资人数
        /// </summary>
        [DisplayName("NewInvestCount")]
        public int NewInvestCount { get; set; }
        /// <summary>
        /// 当日总投资人数
        /// </summary>
        [DisplayName("DayInvestCount")]
        public int DayInvestCount { get; set; }
        /// <summary>
        /// 总投资人数
        /// </summary>
        [DisplayName("InvestCount")]
        public int InvestCount { get; set; }
    }
}

