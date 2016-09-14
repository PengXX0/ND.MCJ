using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户账户详情，用户账单
    /// </summary>
    [Table("AccountDetails")]
    public class AccountDetails : BaseModel
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [DisplayName("AccountDetailId")]
        [Key]
        public int AccountDetailId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 账务类型：详情参考枚举MoneyEventType
        /// </summary>
        [DisplayName("EventType")]
        public int EventType { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// 跟此笔交易记录关联的Id
        /// </summary>
        [DisplayName("AboutId")]
        public String AboutId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

