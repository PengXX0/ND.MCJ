using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 系统账户
    /// </summary>
    [Table("SystemUsers")]
    public class SystemUsers : BaseModel
    {
        /// <summary>
        /// 主键自增
        /// </summary>
        [DisplayName("SysUserId")]
        [Key]
        public int SysUserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// 0 收入  1 支出
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 状态：0禁用  1启用
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}

