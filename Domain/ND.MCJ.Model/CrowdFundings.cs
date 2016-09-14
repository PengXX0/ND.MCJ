using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 众筹项目表
    /// </summary>
    [Table("CrowdFundings")]
    public class CrowdFundings : BaseModel
    {
        /// <summary>
        /// 众筹项目Id，自增
        /// </summary>
        [DisplayName("CrowdFundId")]
        [Key]
        public int CrowdFundId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// 众筹名称
        /// </summary>
        [DisplayName("Name")]
        public String Name { get; set; }
        /// <summary>
        /// 目标金额/融资金融
        /// </summary>
        [DisplayName("TargetAmount")]
        public decimal TargetAmount { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [DisplayName("Profile")]
        public String Profile { get; set; }
        /// <summary>
        /// 项目内容
        /// </summary>
        [DisplayName("Content")]
        public String Content { get; set; }
        /// <summary>
        /// 期限,单位：天
        /// </summary>
        [DisplayName("DueDays")]
        public int DueDays { get; set; }
        /// <summary>
        /// 图片地址，多张图片逗号分割
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// 音频
        /// </summary>
        [DisplayName("Audios")]
        public String Audios { get; set; }
        /// <summary>
        /// 已筹金额
        /// </summary>
        [DisplayName("RaisedAmount")]
        public decimal RaisedAmount { get; set; }
        /// <summary>
        /// 进度，0进行中 1集资完成  2回报中  3结束(成功)  4已撤销  5失败 6禁用（不允许投资）7删除 
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 众筹类型Id   默认0
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 默认为0不推荐，  1推荐
        /// </summary>
        [DisplayName("RecommendSort")]
        public int RecommendSort { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 项目介绍的html内容，H5专用
        /// </summary>
        [DisplayName("HtmlDescription")]
        public String HtmlDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AddContent")]
        public String AddContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AddHtmlDescription")]
        public String AddHtmlDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UpdateDate")]
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 项目成功后的系统收取的手续费
        /// </summary>
        [DisplayName("Poundage")]
        public decimal Poundage { get; set; }
        /// <summary>
        /// 项目成功的时间
        /// </summary>
        [DisplayName("SucDate")]
        public DateTime SucDate { get; set; }
    }
}

