using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ND.MCJ.Model;
using ND.MCJ.DataProvider;

namespace ND.MCJ.IRepository
{
    public interface IUsersRepository : IDependency
    {
        Users Add(Users user);
        Users Find(int userId);
        Users Update(Users user);
        List<Users> FindAll(Expression<Func<Users, bool>> conditions = null);
        PagedList<Users> FindAllByPage<T, TS>(Expression<Func<Users, bool>> conditions, int pageIndex, int pageSize, Expression<Func<Users, TS>> orderBy, bool isDesc);
    }
}
