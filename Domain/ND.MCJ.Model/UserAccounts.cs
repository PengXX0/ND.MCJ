using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 账户（支付宝、微信）   
    /// </summary>
    [Table("UserAccounts")]
    public class UserAccounts : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserAccountId")]
        [Key]
        public int UserAccountId { get; set; }
        /// <summary>
        /// 账户类别ID     1微信 2支付宝   3银行卡
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 账户真实姓名、银行卡持卡人
        /// </summary>
        [DisplayName("RealName")]
        public String RealName { get; set; }
        /// <summary>
        /// 0删除 1预绑定 2确认绑定
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 银行类型ID
        /// </summary>
        [DisplayName("BankTypeId")]
        public int BankTypeId { get; set; }
        /// <summary>
        /// 支付宝账号、微信账号、银行卡号
        /// </summary>
        [DisplayName("AccountNum")]
        public String AccountNum { get; set; }
        /// <summary>
        /// 所在地区县ID
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        [DisplayName("BranchName")]
        public String BranchName { get; set; }
        /// <summary>
        /// 开户行ID
        /// </summary>
        [DisplayName("BranchId")]
        public int BranchId { get; set; }
        /// <summary>
        /// 第三方账户OpenId
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 京东支付Token,用于验证第二次支付免输银行卡
        /// </summary>
        [DisplayName("JdToken")]
        public String JdToken { get; set; }
        /// <summary>
        /// 京东支付银行卡类型
        /// </summary>
        [DisplayName("JdBankTypeId")]
        public int JdBankTypeId { get; set; }
    }
}

