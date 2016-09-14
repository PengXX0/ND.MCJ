using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 用户地址列表
    /// </summary>
    [Table("UserAddressList")]
    public class UserAddressList : BaseModel
    {
        /// <summary>
        /// 主键  
        /// </summary>
        [DisplayName("UserAddresId")]
        [Key]
        public int UserAddresId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [DisplayName("UserId")]
        public String UserId { get; set; }
        /// <summary>
        /// 区县Id
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("RecvName")]
        public String RecvName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 地址详情
        /// </summary>
        [DisplayName("Details")]
        public String Details { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [DisplayName("ZipCode")]
        public String ZipCode { get; set; }
        /// <summary>
        /// 0已删除  1正常 2默认收货地址
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

