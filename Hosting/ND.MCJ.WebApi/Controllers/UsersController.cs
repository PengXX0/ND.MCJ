using AttributeRouting.Web.Http;
using ND.MCJ.AOP.Security.WebApiFilter;
using ND.MCJ.Model;
using ND.MCJ.WebAPIService.Interface;
using System;
using System.Web.Http;

namespace NC.MCJ.WebApi.Controllers
{
    // [Authorization]
    public class UsersController : ApiController
    {
        private readonly IUsersService _usersService;
        private readonly ResponseModel _response;
        public UsersController(IUsersService usersService, ResponseModel response)
        {
            _response = response;
            _usersService = usersService;
        }

        // GET api/user
        [ExceptionAttribute(Caption = "用户列表")]
        [AllowAnonymous]
        //[Route("orders/{id}")]
        public Object Get(string mobile, int pageSize, int pageIndex)
        {
            _response.Data = new { page = _usersService.GetUserList(mobile, pageSize, pageIndex) };
            return _response;
        }

        [AllowAnonymous]
        // GET api/user/5
        [ExceptionAttribute(Caption = "用户详情")]
        [GET("Users/{id}")]
        public Object Get(int id)
        {
            _response.Data = _usersService.GetUser(id);
            return _response;
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
