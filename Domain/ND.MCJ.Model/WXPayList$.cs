using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("WXPayList$")]
    public class WXPayList$ : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("����ʱ��")]
        public DateTime ����ʱ�� { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("΢��֧������")]
        public String ΢��֧������ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("�̻�������")]
        public String �̻������� { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("�̻���")]
        public double �̻��� { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("appid")]
        public String appid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("�µ��û�")]
        public String �µ��û� { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("����״̬")]
        public String ����״̬ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("֧���ɹ�ʱ��")]
        public DateTime ֧���ɹ�ʱ�� { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("���׽��(Ԫ)")]
        public double ���׽��(Ԫ) { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("F10")]
        public String F10 { get; set; }
    }
}

