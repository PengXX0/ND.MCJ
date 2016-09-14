using System.Collections.Generic;
namespace ND.MCJ.DataProvider
{
    public interface IPagedList<T>
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        int RecordCount { get; set; }
        /// <summary>
        /// 当前页数据条数
        /// </summary>
        int CurrentCount { get; set; }
        int PageCount { get;  }
        /// <summary>
        /// 页码
        /// </summary>
        int PageIndex { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// 当前页数据开始序号
        /// </summary>
        int StartIndex { get; }
        /// <summary>
        /// 当前页数据结束序号
        /// </summary>
        int EndIndex { get;  }
        /// <summary>
        /// 当前页数据集
        /// </summary>
        List<T> Rows { get; set; }
    }
}
