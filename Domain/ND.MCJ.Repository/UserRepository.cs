using System.Linq.Expressions;
using ND.MCJ.IRepository;
using ND.MCJ.IRepository.IBase;
using ND.MCJ.Model;

namespace ND.MCJ.Repository
{
    public class UserRepository : DbContextBase, IUsersRepository
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

        public PagedList<Users> FindAllByPage<T, TS>(Expression<System.Func<Users, bool>> conditions, Expression<System.Func<Users, TS>> orderBy, int pageSize, int pageIndex)
        {
            return FindAllByPage(conditions, orderBy, pageSize, pageIndex);
        }
    }
}
