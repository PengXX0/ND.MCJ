using ND.MCJ.DataProvider;
using ND.MCJ.IRepository;
using ND.MCJ.Model;
using ND.MCJ.WebAPIService.Interface;
using System;

namespace ND.MCJ.WebAPIService
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        // [TransactionMethod]
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
