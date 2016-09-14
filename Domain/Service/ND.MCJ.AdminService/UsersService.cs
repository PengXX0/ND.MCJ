using ND.MCJ.AdminService.Interface;
using ND.MCJ.DataProvider;
using ND.MCJ.IRepository;
using ND.MCJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ND.MCJ.AdminWebService
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Users GetUser(int userId)
        {
            return _usersRepository.Find(userId);
        }

        public PagedList<Users> GetUserList(string mobile, int pageIndex, int pageSize)
        {
            return _usersRepository.FindAllByPage<Users, DateTime>(s => s.Mobile.Contains(mobile), pageIndex, pageSize, s => s.CreateDate, true);
        }
    }
}
