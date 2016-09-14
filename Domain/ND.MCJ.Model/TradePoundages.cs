using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("TradePoundages")]
    public class TradePoundages : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("TradePoundageID")]
        [Key]
        public int TradePoundageID { get; set; }
        /// <summary>
        /// ��������  1 ��ֵ 2���� 3�����
        /// </summary>
        [DisplayName("TradeType")]
        public int TradeType { get; set; }
        /// <summary>
        /// ��С���
        /// </summary>
        [DisplayName("MinRange")]
        public decimal MinRange { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        [DisplayName("MaxRange")]
        public decimal MaxRange { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("Poundage")]
        public double Poundage { get; set; }
        /// <summary>
        /// 1���� 2����
        /// </summary>
        [DisplayName("StatusID")]
        public int StatusID { get; set; }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

