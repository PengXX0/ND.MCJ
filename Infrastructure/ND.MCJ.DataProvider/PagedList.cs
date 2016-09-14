using System;
using System.Collections.Generic;
using System.Linq;

namespace ND.MCJ.DataProvider
{
    /// <summary>
    /// 分页数据集合，用于后端返回分页好的集合及前端视图分页控件绑定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T> : IPagedList<T>
    {
        public PagedList(List<T> items, int pageIndex, int pageSize)
        {
            Rows = items;
            PageSize = pageSize;
            PageIndex = pageIndex;
        }

        public PagedList(List<T> items, int pageIndex, int pageSize, int recordCount)
        {
            Rows = items;
            CurrentCount = items.Count();
            RecordCount = recordCount;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int RecordCount { get; set; }
        /// <summary>
        /// 当前页数据条数
        /// </summary>
        public int CurrentCount { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get { return (RecordCount + PageSize - 1) / PageSize; } }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页数据开始序号
        /// </summary>
        public int StartIndex { get { return (PageIndex - 1) * PageSize + 1; } }
        /// <summary>
        /// 当前页数据结束序号
        /// </summary>
        public int EndIndex { get { return RecordCount > PageIndex * PageSize ? PageIndex * PageSize : RecordCount; } }
        /// <summary>
        /// 当前页数据集
        /// </summary>
        public List<T> Rows { get; set; }
    }


    public static class PageLinqExtensions
    {
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> allItems, int pageIndex, int pageSize)
        {
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            var itemIndex = (pageIndex - 1) * pageSize;
            var pageOfItems = allItems.Skip(itemIndex).Take(pageSize).ToList();
            var recordCount = allItems.Count();
            var page = new PagedList<T>(pageOfItems, pageIndex, pageSize, recordCount);
            return page;
        }
    }
}
