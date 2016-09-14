using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �˻������飬�˵�
    /// </summary>
    [Table("SystemAccountDetails")]
    public class SystemAccountDetails : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("SysAccountDetailId")]
        [Key]
        public int SysAccountDetailId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("SysUserId")]
        public int SysUserId { get; set; }
        /// <summary>
        /// ���׽��
        /// </summary>
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        /// <summary>
        /// ϵͳ�˻���ʣ����ǰ���׽���֮������
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Description")]
        public String Description { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

