using ND.MCJ.WebAPIService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NC.MCJ.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService _usersService;
        public HomeController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        public ActionResult Index(int id)
        {
            var data = _usersService.GetUser(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
