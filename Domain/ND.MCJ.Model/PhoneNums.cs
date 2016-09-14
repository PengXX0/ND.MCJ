using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 电话通讯录列表
    /// </summary>
    [Table("PhoneNums")]
    public class PhoneNums : BaseModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DisplayName("PhoneId")]
        [Key]
        public int PhoneId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 电话所有者的姓名
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        [DisplayName("Phone")]
        public String Phone { get; set; }
        /// <summary>
        /// 0删除 1正常
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

