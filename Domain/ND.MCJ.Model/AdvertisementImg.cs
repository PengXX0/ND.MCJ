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
        /// ͼƬ·��
        /// </summary>
        [DisplayName("Images")]
        public String Images { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        [DisplayName("AdvUrl")]
        public String AdvUrl { get; set; }
        /// <summary>
        /// ���ͼƬ����  (��׿) :    1=mdpi(320x480)  2=hdpi(480x800)    3=xhdpi(960*720)  4=xxhdpi(1280��720)   ��IOS��:    5=������� 4/4S    6=������� 5/5S  7= ������� 6/6Plus;    8 = ������� 6S/6S Plus
        /// </summary>
        [DisplayName("ImageType")]
        public int ImageType { get; set; }
        /// <summary>
        /// 1-���� 0-ɾ��
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

