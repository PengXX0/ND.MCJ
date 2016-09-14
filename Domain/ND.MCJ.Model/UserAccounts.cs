using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ND.MCJ.Model
{
    /// <summary>
    /// �˻���֧������΢�ţ�   
    /// </summary>
    [Table("UserAccounts")]
    public class UserAccounts : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName("UserAccountId")]
        [Key]
        public int UserAccountId { get; set; }
        /// <summary>
        /// �˻����ID     1΢�� 2֧����   3���п�
        /// </summary>
        [DisplayName("TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// �û�Id
        /// </summary>
        [DisplayName("UserId")]
        public int UserId { get; set; }
        /// <summary>
        /// �˻���ʵ���������п��ֿ���
        /// </summary>
        [DisplayName("RealName")]
        public String RealName { get; set; }
        /// <summary>
        /// 0ɾ�� 1Ԥ�� 2ȷ�ϰ�
        /// </summary>
        [DisplayName("StatusId")]
        public int StatusId { get; set; }
        /// <summary>
        /// ��������ID
        /// </summary>
        [DisplayName("BankTypeId")]
        public int BankTypeId { get; set; }
        /// <summary>
        /// ֧�����˺š�΢���˺š����п���
        /// </summary>
        [DisplayName("AccountNum")]
        public String AccountNum { get; set; }
        /// <summary>
        /// ���ڵ�����ID
        /// </summary>
        [DisplayName("DistrictId")]
        public int DistrictId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        [DisplayName("BranchName")]
        public String BranchName { get; set; }
        /// <summary>
        /// ������ID
        /// </summary>
        [DisplayName("BranchId")]
        public int BranchId { get; set; }
        /// <summary>
        /// �������˻�OpenId
        /// </summary>
        [DisplayName("OpenId")]
        public String OpenId { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DisplayName("CreateDate")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// ����֧��Token,������֤�ڶ���֧���������п�
        /// </summary>
        [DisplayName("JdToken")]
        public String JdToken { get; set; }
        /// <summary>
        /// ����֧�����п�����
        /// </summary>
        [DisplayName("JdBankTypeId")]
        public int JdBankTypeId { get; set; }
    }
}

