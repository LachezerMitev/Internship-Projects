using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoServiceShopClient.AuthenticationFilters
{
    public class TokenConfirmationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            CheckToken(context, context.HttpContext.Request.RouteValues["token"].ToString()).Wait();
        }

        public async Task CheckToken(ActionExecutingContext context, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

            HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/APISession/GetSessions");

            if (clientTask.IsSuccessStatusCode)
            {
                List<SessionAPI> sessions = JsonConvert.DeserializeObject<List<SessionAPI>>(await clientTask.Content.ReadAsStringAsync());

                if (!sessions.Any(i => i.Token == token))
                    context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                        {{ "token", "" },
                        { "controller", "Auth" },
                        { "action", "LogInIndex" } });
            }
        }
    }
}
