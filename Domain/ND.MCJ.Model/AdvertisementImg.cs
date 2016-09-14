using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("AdvertisementImg")]
    public class AdvertisementImg : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("AsementImgId")]
        [Key]
        public int AsementImgId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [DisplayName("Title")]
        public String Title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("Describe")]
        public String Describe { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// 广告链接
        /// </summary>
        [DisplayName("AdvUrl")]
        public String AdvUrl { get; set; }
        /// <summary>
        /// 广告图片类型  (安卓) :    1=mdpi(320x480)  2=hdpi(480x800)    3=xhdpi(960*720)  4=xxhdpi(1280×720)   （IOS）:    5=适配机型 4/4S    6=适配机型 5/5S  7= 适配机型 6/6Plus;    8 = 适配机型 6S/6S Plus
        /// </summary>
        [DisplayName("ImageType")]
        public int ImageType { get; set; }
        /// <summary>
        /// 1-正常 0-删除
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateData")]
        public DateTime CreateData { get; set; }
    }
}

