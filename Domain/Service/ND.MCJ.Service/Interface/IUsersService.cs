using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ND.MCJ.Model;
using ND.MCJ.DataProvider;

namespace ND.MCJ.WebAPIService.Interface
{
    public interface IUsersService : IDependency
    {
        Users GetUser(int userId);
        PagedList<Users> GetUserList(string mobile, int pageIndex, int pageSize);
    }
}
