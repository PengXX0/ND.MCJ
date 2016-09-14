using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ���ѹ�ϵ��      ��a-->b ,b-->a������������
    /// </summary>
    [Table("ChatFriendships")]
    public class ChatFriendships : BaseModel
    {
        /// <summary>
        /// ��������ID
        /// </summary>
        [DisplayName("FriendshipId")]
        [Key]
        public int FriendshipId { get; set; }
        /// <summary>
        /// �û�ID�����ѹ�ϵ�е�host
        /// </summary>
        [DisplayName("OwnerId")]
        public int OwnerId { get; set; }
        /// <summary>
        /// �û�ID�����ѹ�ϵ�е�Guest
        /// </summary>
        [DisplayName("FriendId")]
        public int FriendId { get; set; }
        /// <summary>
        /// ��ע���ǩ
        /// </summary>
        [DisplayName("Notes")]
        public String Notes { get; set; }
        /// <summary>
        /// �������Ķ�̬��  0���� 1��
        /// </summary>
        [DisplayName("INotSeeHimId")]
        public int INotSeeHimId { get; set; }
        /// <summary>
        /// ���������ҵĶ�̬��0����  1��
        /// </summary>
        [DisplayName("HeNotSeeMeId")]
        public int HeNotSeeMeId { get; set; }
        /// <summary>
        /// ����״̬Id��  0 ����  1������ 2��ɾ�� 
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

