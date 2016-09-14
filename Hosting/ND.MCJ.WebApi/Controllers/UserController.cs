using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ND.MCJ.IService;
using ND.MCJ.Model;

namespace NC.MCJ.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private IUsersService usersService;

        public UserController(IUsersService _usersService)
        {
            usersService = _usersService;
        }

        // GET api/user
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        public Users Get(int id)
        {
            return usersService.GetUser(id);
        }

        // POST api/user
        public void Post([FromBody]string value)
        {
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
        }
    }
}
