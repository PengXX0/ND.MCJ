using ND.MCJ.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ND.MCJ.DataProvider.EntityFramework
{
    public interface IProvider
    {
        T Update<T>(T entity) where T : BaseModel, new();
        T Insert<T>(T entity) where T : BaseModel, new();
        int Delete<T>(T entity) where T : BaseModel, new();
        long Count<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new();
        T FirstOrDefault<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new();
        T FirstOrDefault<T>(string filter, params object[] filterParams) where T : BaseModel, new();
        T First<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new();
        T Find<T>(params object[] keyValues) where T : BaseModel, new();
        List<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new();
        PagedList<T> FindAllByPage<T, TS>(Expression<Func<T, bool>> conditions, int pageIndex, int pageSize, Expression<Func<T, TS>> orderBy, bool isDesc) where T : BaseModel, new();
        IEnumerable SqlQuery<T>(String sql, params Object[] parameters);
        int ExecuteSqlCommand(String sql, params Object[] parameters);
        PagedList<T> FindAllByPage<T>(String selectBody, String selectTable, String sortBody, String whereBody, int pageIndex, int pageSize, bool isDesc, String groupBody = "") where T : class, new();
    }
}
