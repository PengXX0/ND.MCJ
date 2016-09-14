using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ND.MCJ.DataProvider;
using ND.MCJ.Model;

namespace ND.MCJ.AdminService.Interface
{
    public interface IUsersService : IDependency
    {
        Users GetUser(int userId);
        PagedList<Users> GetUserList(string mobile, int pageIndex, int pageSize);
    }
}
