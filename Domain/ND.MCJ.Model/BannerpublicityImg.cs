using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// H5 BannerͼƬ���ñ�
    /// </summary>
    [Table("BannerpublicityImg")]
    public class BannerpublicityImg : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("BannerId")]
        [Key]
        public int BannerId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Title")]
        public String Title { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("Describe")]
        public String Describe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Sort")]
        public int Sort { get; set; }
        /// <summary>
        /// ͼƬ
        /// </summary>
        [DisplayName("Image")]
        public String Image { get; set; }
        /// <summary>
        /// ��תURL
        /// </summary>
        [DisplayName("Url")]
        public String Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("ImageType")]
        public int ImageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

