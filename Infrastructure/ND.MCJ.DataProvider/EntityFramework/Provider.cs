using ND.MCJ.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ND.MCJ.DataProvider.EntityFramework
{
    /// <summary>
    /// 实现Repository通用泛型数据访问模式
    /// </summary>
    public class Provider : DbContext, IProvider
    {
        public Provider()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public Provider(string connectionString)
            : base(connectionString)
        {
            //设置数据库超时时间
            //var objectContext = (this as IObjectContextAdapter).ObjectContext;
            //objectContext.CommandTimeout = 500;
            Database.Connection.ConnectionString = connectionString;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public T Update<T>(T entity) where T : BaseModel, new()
        {
            var set = Set<T>();
            set.Attach(entity);
            Entry(entity).State = EntityState.Modified;
            SaveChanges();
            return entity;
        }

        public long Count<T>(Expression<Func<T, bool>> predicate = null) where T : BaseModel, new()
        {
            return predicate == null ? Set<T>().LongCount() : Set<T>().LongCount(predicate);
        }

        public T FirstOrDefault<T>(Expression<Func<T, bool>> predicate = null) where T : BaseModel, new()
        {
            return predicate == null ? Set<T>().FirstOrDefault() : Set<T>().FirstOrDefault(predicate);
        }

        public T FirstOrDefault<T>(string filter, params Object[] filterParams) where T : BaseModel, new()
        {
            return Database.SqlQuery<T>(filter, filterParams).FirstOrDefault();
        }

        public T First<T>(Expression<Func<T, bool>> predicate = null) where T : BaseModel, new()
        {
            return predicate == null ? Set<T>().First() : Set<T>().First(predicate);
        }

        public T Insert<T>(T entity) where T : BaseModel, new()
        {
            Set<T>().Add(entity);
            SaveChanges();
            return entity;
        }

        public int Delete<T>(T entity) where T : BaseModel, new()
        {
            Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public T Find<T>(params Object[] keyValues) where T : BaseModel, new()
        {
            return Set<T>().Find(keyValues);
        }

        public IEnumerable SqlQuery<T>(String sql, params Object[] parameters)
        {
            return Database.SqlQuery<T>(sql, parameters);
        }

        public int ExecuteSqlCommand(String sql, params Object[] parameters)
        {
            return Database.ExecuteSqlCommand(sql, parameters);
        }

        public List<T> FindAll<T>(Expression<Func<T, bool>> predicate = null) where T : BaseModel, new()
        {
            return predicate == null ? Set<T>().ToList() : Set<T>().Where(predicate).ToList();
        }

        public PagedList<T> FindAllByPage<T, TS>(Expression<Func<T, bool>> predicate, int pageIndex, int pageSize, Expression<Func<T, TS>> orderBy, bool isDesc = true) where T : BaseModel, new()
        {
            var queryList = predicate == null ? Set<T>() : Set<T>().Where(predicate);
            return (isDesc ? queryList.OrderByDescending(orderBy) : queryList.OrderBy(orderBy)).ToPagedList(pageIndex, pageSize);
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
        public PagedList<T> FindAllByPage<T>(String selectBody, String selectTable, String sortBody, String whereBody, int pageIndex, int pageSize, bool isDesc, String groupBody = "") where T : class, new()
        {
            if (String.IsNullOrEmpty(selectBody))
                throw new Exception("Select body can not be null");
            if (String.IsNullOrEmpty(selectTable))
                throw new Exception("From body can not be null");
            var where = new StringBuilder();
            if (String.IsNullOrEmpty(whereBody) == false)
            { where = where.AppendFormat(" WHERE {0} ", whereBody); }
            var sort = new StringBuilder();
            if (String.IsNullOrEmpty(sortBody) == false)
            { sort = sort.AppendFormat((" ORDER BY {0} " + (isDesc ? " DESC " : " ASC ")), sortBody); }
            var group = new StringBuilder();
            if (String.IsNullOrEmpty(groupBody) == false)
            { group = group.AppendFormat(" GROUP BY {0} ", groupBody); }
            StringBuilder sql = new StringBuilder();
            var countSql = new StringBuilder().AppendFormat("SELECT COUNT(1) FROM {0} {1}", selectTable, where);
            var recordCount = Database.SqlQuery<int>(countSql.ToString()).First();
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
            var list = Database.SqlQuery<T>(sql.ToString()).ToList();
            return new PagedList<T>(list, pageIndex, pageSize, recordCount);
        }
        public override int SaveChanges()
        {
            var result = base.SaveChanges();
            return result;
        }

        #region DbSet
        public DbSet<AccountDetails> AccountDetails { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<AccountWithDrawals> AccountWithDrawals { get; set; }
        public DbSet<AdminActivitys> AdminActivitys { get; set; }
        public DbSet<AdvertisementImg> AdvertisementImg { get; set; }
        public DbSet<AlipayBills> AlipayBills { get; set; }
        public DbSet<BankBranchs> BankBranchs { get; set; }
        public DbSet<BankTypes> BankTypes { get; set; }
        public DbSet<BannerpublicityImg> BannerpublicityImg { get; set; }
        public DbSet<C_Citys> C_Citys { get; set; }
        public DbSet<C_Provinces> C_Provinces { get; set; }
        public DbSet<ChatFriendApplications> ChatFriendApplications { get; set; }
        public DbSet<ChatFriendships> ChatFriendships { get; set; }
        public DbSet<ChatGroupNotices> ChatGroupNotices { get; set; }
        public DbSet<ChatGroups> ChatGroups { get; set; }
        public DbSet<ChatGroupUsers> ChatGroupUsers { get; set; }
        public DbSet<ChatMessage> ChatMessage { get; set; }
        public DbSet<Citys> Citys { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<CrowdFundings> CrowdFundings { get; set; }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<Feedbacks> Feedbacks { get; set; }
        public DbSet<IdentityAuthentication> IdentityAuthentication { get; set; }
        public DbSet<InpourOnlineDetails> InpourOnlineDetails { get; set; }
        public DbSet<InpourOnlines> InpourOnlines { get; set; }
        public DbSet<JdBankTypes> JdBankTypes { get; set; }
        public DbSet<MessageSetting> MessageSetting { get; set; }
        public DbSet<MobileCodes> MobileCodes { get; set; }
        public DbSet<MobileMessages> MobileMessages { get; set; }
        public DbSet<NewBalance> NewBalance { get; set; }
        public DbSet<PasswordChangeLog> PasswordChangeLog { get; set; }
        public DbSet<PhoneNums> PhoneNums { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<RechargeLogs> RechargeLogs { get; set; }
        public DbSet<RegisterStats> RegisterStats { get; set; }
        public DbSet<RepayWays> RepayWays { get; set; }
        public DbSet<ReportLists> ReportLists { get; set; }
        public DbSet<SupportProjects> SupportProjects { get; set; }
        public DbSet<SYS_AdminActivitys> SYS_AdminActivitys { get; set; }
        public DbSet<SYS_ButtonPermissions> SYS_ButtonPermissions { get; set; }
        public DbSet<SYS_MenuPermissions> SYS_MenuPermissions { get; set; }
        public DbSet<SYS_MethodPermissions> SYS_MethodPermissions { get; set; }
        public DbSet<SYS_RoleButtons> SYS_RoleButtons { get; set; }
        public DbSet<SYS_RoleMenus> SYS_RoleMenus { get; set; }
        public DbSet<SYS_RoleMethods> SYS_RoleMethods { get; set; }
        public DbSet<SYS_Roles> SYS_Roles { get; set; }
        public DbSet<SYS_Users> SYS_Users { get; set; }
        public DbSet<SystemAccountDetails> SystemAccountDetails { get; set; }
        public DbSet<SystemAccounts> SystemAccounts { get; set; }
        public DbSet<SystemMessages> SystemMessages { get; set; }
        public DbSet<SystemUsers> SystemUsers { get; set; }
        public DbSet<SystemWithdrawLogs> SystemWithdrawLogs { get; set; }
        public DbSet<ThirdpartyConfig> ThirdpartyConfig { get; set; }
        public DbSet<ThirdPartyUsers> ThirdPartyUsers { get; set; }
        public DbSet<TradePoundages> TradePoundages { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; }
        public DbSet<UserActivitys> UserActivitys { get; set; }
        public DbSet<UserAddressList> UserAddressList { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserLoginLog> UserLoginLog { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserValidates> UserValidates { get; set; }
        public DbSet<WechatBill> WechatBill { get; set; }
        public DbSet<WechatBillDetails> WechatBillDetails { get; set; }
        #endregion
    }
}
