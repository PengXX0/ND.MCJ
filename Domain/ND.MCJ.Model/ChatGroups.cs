using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 交流群，聊天群
    /// </summary>
    [Table("ChatGroups")]
    public class ChatGroups : BaseModel
    {
        /// <summary>
        /// 群ID，自增主键
        /// </summary>
        [DisplayName("GroupId")]
        [Key]
        public int GroupId { get; set; }
        /// <summary>
        /// 环信群Id
        /// </summary>
        [DisplayName("EasemobGroupId")]
        public String EasemobGroupId { get; set; }
        /// <summary>
        /// 群主
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 群图像地址
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// 群状态  0禁用  1启用   
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 众筹ID，可为空
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 群名称
        /// </summary>
        [DisplayName("GroupName")]
        public String GroupName { get; set; }
        /// <summary>
        /// 群最大成员数
        /// </summary>
        [DisplayName("MaxUser")]
        public int MaxUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

