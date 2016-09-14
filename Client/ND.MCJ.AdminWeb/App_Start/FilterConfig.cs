using ND.MCJ.AOP.Security.MvcFilter;
using System.Web;
using System.Web.Mvc;

namespace ND.MCJ.AdminWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new JsonNetAttribute());
        }
    }
}