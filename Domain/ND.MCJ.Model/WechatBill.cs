using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ΢���˵�ͳ��
    /// </summary>
    [Table("WechatBill")]
    public class WechatBill : BaseModel
    {
        /// <summary>
        /// ���� ����
        /// </summary>
        [DisplayName("WechatBillId")]
        [Key]
        public int WechatBillId { get; set; }
        /// <summary>
        /// ���˵�����
        /// </summary>
        [DisplayName("BillDate")]
        public String BillDate { get; set; }
        /// <summary>
        /// �ܽ��׵���
        /// </summary>
        [DisplayName("TotalTradeCount")]
        public int TotalTradeCount { get; set; }
        /// <summary>
        /// �ܽ��׶�
        /// </summary>
        [DisplayName("TotalTradeAmount")]
        public decimal TotalTradeAmount { get; set; }
        /// <summary>
        /// ���˿���
        /// </summary>
        [DisplayName("TotalRefundAmount")]
        public decimal TotalRefundAmount { get; set; }
        /// <summary>
        /// ����ȯ�������Żݽ��
        /// </summary>
        [DisplayName("TotalCouponAmount")]
        public decimal TotalCouponAmount { get; set; }
        /// <summary>
        /// �������ܽ��
        /// </summary>
        [DisplayName("TotalCounterAmount")]
        public decimal TotalCounterAmount { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

