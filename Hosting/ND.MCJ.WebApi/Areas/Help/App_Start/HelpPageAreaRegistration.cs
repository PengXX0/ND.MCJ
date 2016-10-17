using System.Web.Http;
using System.Web.Mvc;

namespace NC.MCJ.WebApi.Areas.Help.App_Start
{
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "Help"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Default_Help",
                "Help/{controller}/{action}",
                new { controller = "Dev", action = "Docs" },
                new[] { "NC.MCJ.WebApi.Areas.Help.Controllers" });
            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}