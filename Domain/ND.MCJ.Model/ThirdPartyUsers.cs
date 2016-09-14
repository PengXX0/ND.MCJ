using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// ������ע���û���
    /// </summary>
    [Table("ThirdPartyUsers")]
    public class ThirdPartyUsers : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("TPUserId")]
        [Key]
        public int TPUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �˺�����  0΢��  1΢��  2QQ
        /// </summary>
        [DisplayName("Type")]
        public int Type { get; set; }
        /// <summary>
        /// ������Ӧ���ṩ��Id
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// �ǳ�
        /// </summary>
        [DisplayName("NickName")]
        public String NickName { get; set; }
        /// <summary>
        /// 0δ֪  1��  2Ů
        /// </summary>
        [DisplayName("Sex")]
        public int Sex { get; set; }
        /// <summary>
        /// ����ʡ
        /// </summary>
        [DisplayName("Province")]
        public String Province { get; set; }
        /// <summary>
        /// ���ڳ���
        /// </summary>
        [DisplayName("City")]
        public String City { get; set; }
        /// <summary>
        /// ͼ���ַ
        /// </summary>
        [DisplayName("Avatar")]
        public String Avatar { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// ΢�ŵ�OpenId, ΢�Ź��ں���Ӷ�Ӧ��,OpenId��Ψһ��UnionId��OpenId�������ʱ����
        /// </summary>
        [DisplayName("UnionId")]
        public String UnionId { get; set; }
    }
}

