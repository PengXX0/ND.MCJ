using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ΢���˵�����
    /// </summary>
    [Table("WechatBillDetails")]
    public class WechatBillDetails : BaseModel
    {
        /// <summary>
        /// 
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
        /// ����ʱ��
        /// </summary>
        [DisplayName("TradeTime")]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// ���ں�Id
        /// </summary>
        [DisplayName("AppId")]
        public String AppId { get; set; }
        /// <summary>
        /// �̻���
        /// </summary>
        [DisplayName("MchId")]
        public String MchId { get; set; }
        /// <summary>
        /// ���̻���
        /// </summary>
        [DisplayName("SubMchId")]
        public String SubMchId { get; set; }
        /// <summary>
        /// �豸��
        /// </summary>
        [DisplayName("DeviceInfo")]
        public String DeviceInfo { get; set; }
        /// <summary>
        /// ΢��֧��������
        /// </summary>
        [DisplayName("TransactionId")]
        public String TransactionId { get; set; }
        /// <summary>
        /// �̻�������
        /// </summary>
        [DisplayName("OutTradeNo")]
        public String OutTradeNo { get; set; }
        /// <summary>
        /// �û���ʶ
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("TradeType")]
        public String TradeType { get; set; }
        /// <summary>
        /// ����״̬
        /// </summary>
        [DisplayName("TradeStatus")]
        public String TradeStatus { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("BankType")]
        public String BankType { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("FeeType")]
        public String FeeType { get; set; }
        /// <summary>
        /// �ܽ��
        /// </summary>
        [DisplayName("TotalFee")]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// ����ȯ�������Żݽ��
        /// </summary>
        [DisplayName("CouponFee")]
        public decimal CouponFee { get; set; }
        /// <summary>
        /// �̻��˿��
        /// </summary>
        [DisplayName("OutRefundNo")]
        public String OutRefundNo { get; set; }
        /// <summary>
        /// ΢���˿��
        /// </summary>
        [DisplayName("RefundId")]
        public String RefundId { get; set; }
        /// <summary>
        /// �˿���
        /// </summary>
        [DisplayName("RefundFee")]
        public decimal RefundFee { get; set; }
        /// <summary>
        /// ����ȯ�������Ż��˿���
        /// </summary>
        [DisplayName("CouponRefundFee")]
        public decimal CouponRefundFee { get; set; }
        /// <summary>
        /// �˿�����
        /// </summary>
        [DisplayName("RefundType")]
        public String RefundType { get; set; }
        /// <summary>
        /// �˿�״̬
        /// </summary>
        [DisplayName("RefundStatus")]
        public String RefundStatus { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        [DisplayName("GoodsName")]
        public String GoodsName { get; set; }
        /// <summary>
        /// �̼����ݰ�
        /// </summary>
        [DisplayName("Attach")]
        public String Attach { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("CounterFee")]
        public decimal CounterFee { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

