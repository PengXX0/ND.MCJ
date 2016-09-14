using System.Web;
using System.Web.Mvc;
using ND.MCJ.AOP.Security.MvcFilter;

namespace NC.MCJ.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new JsonNetAttribute());
            filters.Add(new ExceptionAttribute());
        }
    }
}