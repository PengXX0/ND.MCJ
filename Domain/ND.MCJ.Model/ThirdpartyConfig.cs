using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 第三方配置表
    /// </summary>
    [Table("ThirdpartyConfig")]
    public class ThirdpartyConfig : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Id")]
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 发件人
        /// </summary>
        [DisplayName("FromEmail")]
        public String FromEmail { get; set; }
        /// <summary>
        /// 服务器
        /// </summary>
        [DisplayName("MailServer")]
        public String MailServer { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("MailUserName")]
        public String MailUserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("MailPassword")]
        public String MailPassword { get; set; }
        /// <summary>
        /// 端口号
        /// </summary>
        [DisplayName("MailPort")]
        public int MailPort { get; set; }
        /// <summary>
        /// 短信供应商
        /// </summary>
        [DisplayName("SmsSuppliers")]
        public String SmsSuppliers { get; set; }
        /// <summary>
        /// 短信用户名
        /// </summary>
        [DisplayName("SmsUserName")]
        public String SmsUserName { get; set; }
        /// <summary>
        /// 短信密码
        /// </summary>
        [DisplayName("SmsPassword")]
        public String SmsPassword { get; set; }
        /// <summary>
        /// 企业Id
        /// </summary>
        [DisplayName("EnterpriseId")]
        public int EnterpriseId { get; set; }
    }
}

