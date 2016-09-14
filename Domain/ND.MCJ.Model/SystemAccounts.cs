using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ϵͳ�˻���
    /// </summary>
    [Table("SystemAccounts")]
    public class SystemAccounts : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysUserId")]
        [Key]
        public int SysUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// �˻����
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

