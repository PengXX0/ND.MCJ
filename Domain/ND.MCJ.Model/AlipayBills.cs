using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ֧�����˵���ϸ
    /// </summary>
    [Table("AlipayBills")]
    public class AlipayBills : BaseModel
    {
        /// <summary>
        /// Id���� ����
        /// </summary>
        [DisplayName("AlipayBillId")]
        [Key]
        public int AlipayBillId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("BillDate")]
        public String BillDate { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("Type")]
        public String Type { get; set; }
        /// <summary>
        /// ҵ������
        /// </summary>
        [DisplayName("BusinessType")]
        public String BusinessType { get; set; }
        /// <summary>
        /// ֧����������
        /// </summary>
        [DisplayName("AlipayOrderNo")]
        public String AlipayOrderNo { get; set; }
        /// <summary>
        /// �̻�������
        /// </summary>
        [DisplayName("MerchantOrderNo")]
        public String MerchantOrderNo { get; set; }
        /// <summary>
        /// ����֧�����˻�ID
        /// </summary>
        [DisplayName("SelfUserId")]
        public String SelfUserId { get; set; }
        /// <summary>
        /// �Է�֧�����˻�ID
        /// </summary>
        [DisplayName("OptUserId")]
        public String OptUserId { get; set; }
        /// <summary>
        /// 	������
        /// </summary>
        [DisplayName("InAmount")]
        public decimal InAmount { get; set; }
        /// <summary>
        /// ֧�����
        /// </summary>
        [DisplayName("OutAmount")]
        public decimal OutAmount { get; set; }
        /// <summary>
        /// ��ʱ�˻������
        /// </summary>
        [DisplayName("Balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// ����ע˵��
        /// </summary>
        [DisplayName("Memo")]
        public String Memo { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateTime")]
        public DateTime CreateTime { get; set; }
    }
}

