using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 举报列表   举报用户、群列表   (用户被举报以后自动加入黑名单)
    /// </summary>
    [Table("ReportLists")]
    public class ReportLists : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ReportId")]
        [Key]
        public int ReportId { get; set; }
        /// <summary>
        /// 举报人
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 举报类型  0群  1用户
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 被举报对象   可以是被举报用户Id    也可以是群Id
        /// </summary>
        [DisplayName("ObjectId")]
        public int ObjectId { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        [DisplayName("Reason")]
        public String Reason { get; set; }
        /// <summary>
        /// 0审核中  1不通过  2通过
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

