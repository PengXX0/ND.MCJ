using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("InpourOnlines")]
    public class InpourOnlines : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("OnlineId")]
        [Key]
        public int OnlineId { get; set; }
        /// <summary>
        /// ���׺ţ��������֧��ƽ̨Ψһ��ʶ
        /// </summary>
        [DisplayName("DealingId")]
        public String DealingId { get; set; }
        /// <summary>
        /// ֧�ַ�ʽ   ֱ�ӳ�ֵ֧��
        /// </summary>
        [DisplayName("TransactionId")]
        public String TransactionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        ///  1΢�ţ�2֧������3����
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        ///  0 ��֧��  1�ɹ�  2ʧ��   
        /// </summary>
        [DisplayName("ResultId")]
        public int ResultId { get; set; }
        /// <summary>
        /// ��ֵ���   
        /// </summary>
        [DisplayName("TotalFee")]
        public decimal TotalFee { get; set; }
        /// <summary>
        /// ʵ�ʳ�����   
        /// </summary>
        [DisplayName("TotalPay")]
        public decimal TotalPay { get; set; }
        /// <summary>
        /// ��ʱ��ֵ�ɹ�ʱ��   
        /// </summary>
        [DisplayName("ReturnDate")]
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("IP")]
        public String IP { get; set; }
        /// <summary>
        /// ���׹ر�ʱ��   
        /// </summary>
        [DisplayName("DealingDate")]
        public DateTime DealingDate { get; set; }
        /// <summary>
        /// ���𸶿�ʱ�䣬Ҳ���ǳ�ֵҳ���ȷ��   
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

