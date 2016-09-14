using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �ֻ���֤��
    /// </summary>
    [Table("MobileCodes")]
    public class MobileCodes : BaseModel
    {
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("MobileCodeId")]
        [Key]
        public int MobileCodeId { get; set; }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        [DisplayName("Mobile")]
        public String Mobile { get; set; }
        /// <summary>
        /// ��֤��
        /// </summary>
        [DisplayName("Code")]
        public String Code { get; set; }
        /// <summary>
        /// ��֤�����ͣ�1ע��
        /// </summary>
        [DisplayName("CodeTypeId")]
        public int CodeTypeId { get; set; }
        /// <summary>
        /// ״̬��0δʹ�ã�1��ʹ�ã�2����
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
    }
}

