using System.Web.Http;
using System.Web.Mvc;

namespace NC.MCJ.WebApi.Areas.Help
{
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "Help"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Default_Help",
                "Help/{controller}/{action}",
                new { controller = "Dev", action = "Docs"});
            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}