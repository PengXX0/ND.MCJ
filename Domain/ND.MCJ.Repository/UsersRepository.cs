using ND.MCJ.DataProvider;
using ND.MCJ.DataProvider.OrmLite;
using ND.MCJ.IRepository;
using ND.MCJ.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ND.MCJ.Repository
{
    public class UsersRepository : Provider, IUsersRepository
    {
        public Users Add(Users user)
        {
            return Insert(user);
        }

        public Users Find(int userId)
        {
            return Find<Users>(userId);
        }

        public Users Update(Users user)
        {
            return Update<Users>(user);
        }

        public PagedList<Users> FindAllByPage<T, TS>(Expression<Func<Users, bool>> conditions, int pageIndex, int pageSize, Expression<Func<Users, TS>> orderBy, bool isDesc)
        {
            return FindAllByPage(conditions, pageIndex, pageSize, orderBy, isDesc);
        }

        public List<Users> FindAll(Expression<Func<Users, bool>> conditions = null)
        {
            return FindAll<Users>(conditions);
        }
    }
}
