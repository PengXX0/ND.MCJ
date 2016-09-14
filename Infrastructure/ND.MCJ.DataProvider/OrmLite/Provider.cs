using System;
using System.Configuration;
using System.Data;
using System.Transactions;
using ServiceStack.OrmLite;
using System.Text;
using ServiceStack.Text;
using ND.MCJ.Model;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;

namespace ND.MCJ.DataProvider.OrmLite
{
    public class Provider : DbContext, IProvider
    {
        public Provider() : base("DefaultConnection") { }

        public Provider(string connectionString) : base(connectionString) { }

        public T Update<T>(T entity) where T : BaseModel, new()
        {
            Run(db => db.Update(entity));
            return entity;
            //return Run<int>(db => db.ExecuteNonQuery(new InternalSqlExpressionVisitor<T>().ToUpdateStatement(entity, true)));
        }

        public long Count<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new()
        {
            return Run(db => db.Count(conditions));
        }

        public T FirstOrDefault<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new()
        {
            return Run(db => db.FirstOrDefault(conditions));
        }

        public T FirstOrDefault<T>(String sql, params Object[] parameters) where T : BaseModel, new()
        {
            return Run(db => db.FirstOrDefault<T>(sql, parameters));
        }

        public T First<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new()
        {
            return Run(db => db.First(conditions));
        }

        public T Delete<T>(T entity) where T : BaseModel, new()
        {
            Run(db => db.Delete(entity));
            return entity;
        }

        public T Insert<T>(T entity) where T : BaseModel, new()
        {
            var identityId = Run(db => db.InsertParam(entity, true));
            return Run(db => db.GetByIdParam<T>(identityId));
        }

        public T Find<T>(object id) where T : BaseModel, new()
        {
            return Run(db => db.GetByIdParam<T>(id));
        }
        public List<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : BaseModel, new()
        {
            return Run(db => db.Where(conditions));
        }

        public IEnumerable SqlQuery<T>(String sql, params Object[] parameters)
        {
            return Run(db => db.Select<T>(sql, parameters));
        }

        public int ExecuteSqlCommand(String sql, params Object[] parameters)
        {
            return Run(db => db.Scalar<int>(sql, parameters));
        }

        public PagedList<T> FindAllByPage<T, TS>(Expression<Func<T, bool>> conditions, int pageIndex, int pageSize, Expression<Func<T, TS>> orderBy, bool isDesc) where T : BaseModel, new()
        {
            var pageBegion = (pageIndex - 1) * pageSize;
            var ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<T>(); ev.Where(conditions);
            if (!isDesc) { ev.OrderBy(orderBy); }
            else { ev.OrderByDescending(orderBy); }
            var recordCount = Run(db => db.Select(ev).Count);
            ev.Limit(pageBegion, pageSize);
            var rows = Run(db => db.Select(ev));
            return new PagedList<T>(rows, pageIndex, pageSize, recordCount);
        }

        /// <summary>
        /// SQL分页处理方法
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="pageIndex">页码>=1</param>
        /// <param name="pageSize">每页大小, >=1</param>
        /// <param name="selectBody">查询字段，支持多表查询（不包括selct关键字）</param>
        /// <param name="selectTable">查询的表名，支持视图（不包括from关键字）</param>
        /// <param name="sortBody">排序字段</param>
        /// <param name="whereBody">查询条件（不包括where关键字）</param>
        /// <param name="isDesc">是否为降序</param>
        /// <param name="groupBody">分组</param>
        /// <returns></returns>
        public PagedList<T> FindAllByPage<T>(String selectBody, String selectTable, String sortBody, String whereBody, int pageIndex, int pageSize, bool isDesc, String groupBody = "") where T : BaseModel, new()
        {
            if (String.IsNullOrEmpty(selectBody))
                throw new Exception("select body can not be null");
            if (String.IsNullOrEmpty(selectTable))
                throw new Exception("from body can not be null");
            var where = new StringBuilder();
            if (String.IsNullOrEmpty(whereBody) == false)
            { where = where.AppendFormat(" WHERE {0} ", whereBody); }
            var sort = new StringBuilder();
            if (String.IsNullOrEmpty(sortBody) == false)
            { sort = sort.AppendFormat((" ORDER BY {0} " + (isDesc ? " DESC " : " ASC ")), sortBody); }
            var group = new StringBuilder();
            if (String.IsNullOrEmpty(groupBody) == false)
            { group = group.AppendFormat(" GROUP BY {0} ", groupBody); }
            var sql = new StringBuilder();
            var countSql = new StringBuilder().AppendFormat("SELECT COUNT(1) FROM {0} {1}", selectTable, where);
            var recordCount = Run(db => db.Scalar<int>(countSql.ToString()));
            if (pageIndex == -1)
            { sql = sql.AppendFormat(" SELECT {0} FROM {1} {2} {3} {4}", selectBody, selectTable, where, group, sort); }
            else
            {
                pageIndex = pageIndex < 1 ? 1 : pageIndex;
                pageSize = pageSize <= 1 ? 1 : pageSize;
                sql = sql.AppendFormat(@"SELECT *  FROM ( SELECT  Row_Number() OVER ({4}) AS _RowID, {0} FROM {1} {2} {3} ) AS T 
                                                   WHERE T._RowID > (({6} - 1) * {5})  AND T._RowID <= ({6} * {5})  
                                                   ORDER BY _RowID ASC;", selectBody, selectTable, where, group, sort, pageSize, pageIndex);
            }
            var list = Run(db => db.Select<T>(sql.ToString()));
            return new PagedList<T>(list, pageIndex, pageSize, recordCount);
        }

        #region Foo
        public static OrmLiteConnectionFactory Switch(string connectionStringName)
        {
            return OrmLiteConnectionFactory.NamedConnections[connectionStringName];
        }
        /// <summary>
        /// 事务
        /// </summary>
        /// <param name="action"></param>
        public static void DoDBTrans(Action<IDbConnection> action)
        {
            IDbTransaction newDBTran = null;
            IDbConnection newDBConn = Db.CreateDbConnection();
            newDBConn.Open();
            try
            {
                newDBTran = newDBConn.BeginTransaction();
                if (null != action)
                    action(newDBConn);

                if (newDBTran != null)
                    newDBTran.Commit();
            }
            catch (Exception ex)
            {
                //发生异常，回滚事务。
                if (null != newDBTran)
                    newDBTran.Rollback();
                throw;
            }
            finally
            {
                if (null != newDBTran)
                {
                    if (newDBConn.State == ConnectionState.Open)
                        newDBConn.Close();
                    newDBConn.Dispose();
                }
            }
        }

        private sealed class InternalSqlExpressionVisitor<T> : SqlExpressionVisitor<T>
        {
            public override string ToUpdateStatement(T item, bool excludeDefaults = true)
            {
                if (ModelDef.FieldDefinitions.Count == 0)
                {
                    throw new ArgumentException("无效类型：{0}，类型中没有定义任何字段。".Fmt(typeof(T)));
                }

                var setFields = new StringBuilder();
                var provider = OrmLiteConfig.DialectProvider;

                foreach (var fieldDef in ModelDef.FieldDefinitions)
                {
                    var value = fieldDef.GetValue(item);
                    if (fieldDef.IsPrimaryKey)
                    {
                        WhereExpression = string.Format(" WHERE {0} = {1}",
                            provider.GetQuotedColumnName(fieldDef.FieldName),
                            provider.GetQuotedValue(value, fieldDef.FieldType));
                        continue;
                    }

                    if (fieldDef.IsComputed || fieldDef.AutoIncrement) continue;
                    if (excludeDefaults && (value == null || value.Equals(value.GetType().GetDefaultValue()))) continue;

                    if (setFields.Length > 0) setFields.Append(",");
                    setFields.AppendFormat("{0} = {1}",
                        provider.GetQuotedColumnName(fieldDef.FieldName),
                        provider.GetQuotedValue(value, fieldDef.FieldType));
                }

                return string.Format("UPDATE {0} SET {1}{2}",
                    provider.GetQuotedTableName(ModelDef), setFields, WhereExpression);
            }
        }
        #endregion
    }
}
