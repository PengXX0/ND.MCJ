using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �û��˻�
    /// </summary>
    [Table("Accounts")]
    public class Accounts : BaseModel
    {
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// �˻��ܶ����������
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// ֧���ڳ���Ŀ�������
        /// </summary>
        [DisplayName("LockedBalance")]
        public decimal LockedBalance { get; set; }
        /// <summary>
        /// �����������
        /// </summary>
        [DisplayName("DrawLocked")]
        public decimal DrawLocked { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

