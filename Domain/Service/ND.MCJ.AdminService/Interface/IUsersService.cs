using ND.MCJ.DataProvider;
using ND.MCJ.Model;

namespace ND.MCJ.AdminWebService.Interface
{
    public interface IUsersService : IDependency
    {
        Users GetUser(int userId);
        PagedList<Users> GetUserList(string mobile, int pageIndex, int pageSize);
    }
}
