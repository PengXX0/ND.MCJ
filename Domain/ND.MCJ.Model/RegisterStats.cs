using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("RegisterStats")]
    public class RegisterStats : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Id")]
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// ��������ע����
        /// </summary>
        [DisplayName("DayRegCount")]
        public int DayRegCount { get; set; }
        /// <summary>
        /// �ۼ�ע����
        /// </summary>
        [DisplayName("RegCount")]
        public int RegCount { get; set; }
        /// <summary>
        /// ����������Ŀ����
        /// </summary>
        [DisplayName("NewLaunchCount")]
        public int NewLaunchCount { get; set; }
        /// <summary>
        /// �����ܷ�����Ŀ����
        /// </summary>
        [DisplayName("DayLaunchCount")]
        public int DayLaunchCount { get; set; }
        /// <summary>
        /// �ۼƷ�����Ŀ����
        /// </summary>
        [DisplayName("LaunchCount")]
        public int LaunchCount { get; set; }
        /// <summary>
        /// ����Ͷ������
        /// </summary>
        [DisplayName("NewInvestCount")]
        public int NewInvestCount { get; set; }
        /// <summary>
        /// ������Ͷ������
        /// </summary>
        [DisplayName("DayInvestCount")]
        public int DayInvestCount { get; set; }
        /// <summary>
        /// ��Ͷ������
        /// </summary>
        [DisplayName("InvestCount")]
        public int InvestCount { get; set; }
    }
}

