using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户支持的项目列表
    /// </summary>
    [Table("SupportProjects")]
    public class SupportProjects : BaseModel
    {
        /// <summary>
        /// 主键自增
        /// </summary>
        [DisplayName("SupportProjectId")]
        [Key]
        public int SupportProjectId { get; set; }
        /// <summary>
        /// 支持者
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 项目ID
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 回报ID
        /// </summary>
        [DisplayName("RepayId")]
        public int RepayId { get; set; }
        /// <summary>
        /// 投资金额
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 0待回报  1回报中  2已回报  3已失败  4已删除
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 用户地址Id
        /// </summary>
        [DisplayName("UserAddresId")]
        public int UserAddresId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 用户支付金额状态 0未到账 1已到账
        /// </summary>
        [DisplayName("AmountStatusId")]
        public int AmountStatusId { get; set; }
        /// <summary>
        /// 支付类型Id
        /// </summary>
        [DisplayName("PayTypeId")]
        public int PayTypeId { get; set; }
        /// <summary>
        /// 备注，保存支持项目时填写的评论信息
        /// </summary>
        [DisplayName("Remark")]
        public String Remark { get; set; }
    }
}

