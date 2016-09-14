using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ���������
    /// </summary>
    [Table("ChatFriendApplications")]
    public class ChatFriendApplications : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("FriendApplyId")]
        [Key]
        public int FriendApplyId { get; set; }
        /// <summary>
        /// 0��������   1��������
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// �û��Լ���Id
        /// </summary>
        [DisplayName("OwnerId")]
        public int OwnerId { get; set; }
        /// <summary>
        /// Ҫ��Ӻ��ѵ�Id
        /// </summary>
        [DisplayName("FriendId")]
        public int FriendId { get; set; }
        /// <summary>
        /// �ֻ�    (����Ǻ����������д�ֻ�)
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// 0������  1ͨ��  2�ܾ�   3����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        [DisplayName("ModifyDate")]
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

