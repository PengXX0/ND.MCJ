using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ����Ⱥ������Ⱥ
    /// </summary>
    [Table("ChatGroups")]
    public class ChatGroups : BaseModel
    {
        /// <summary>
        /// ȺID����������
        /// </summary>
        [DisplayName("GroupId")]
        [Key]
        public int GroupId { get; set; }
        /// <summary>
        /// ����ȺId
        /// </summary>
        [DisplayName("EasemobGroupId")]
        public String EasemobGroupId { get; set; }
        /// <summary>
        /// Ⱥ��
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// Ⱥͼ���ַ
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// Ⱥ״̬  0����  1����   
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �ڳ�ID����Ϊ��
        /// </summary>
        [DisplayName("CrowdFundId")]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// Ⱥ����
        /// </summary>
        [DisplayName("GroupName")]
        public String GroupName { get; set; }
        /// <summary>
        /// Ⱥ����Ա��
        /// </summary>
        [DisplayName("MaxUser")]
        public int MaxUser { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

