using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ��Ϣ��������
    /// </summary>
    [Table("MessageSetting")]
    public class MessageSetting : BaseModel
    {
        /// <summary>
        /// �û���Ϊ����
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// �Ƿ���ʾ֪ͨ��Ϣ����   0����ʾ   1��ʾ
        /// </summary>
        [DisplayName("IsShowDetails")]
        public int IsShowDetails { get; set; }
        /// <summary>
        /// ��Ϣ�����      0����      1ҹ�俪��      2�ر�
        /// </summary>
        [DisplayName("MsgTrouble")]
        public int MsgTrouble { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

