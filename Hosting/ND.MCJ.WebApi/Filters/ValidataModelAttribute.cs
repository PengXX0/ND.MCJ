using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace NC.MCJ.WebApi.Filters
{
    public class ValidataModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid) return;
            var errors = new Dictionary<String, IEnumerable<String>>();
            actionContext.ModelState.ToList().ForEach(s => { errors[s.Key] = s.Value.Errors.Select(e => e.ErrorMessage); });
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK,
            new { code = HttpStatusCode.BadRequest, message = errors.FirstOrDefault().Value.FirstOrDefault() });
        }
    }
}