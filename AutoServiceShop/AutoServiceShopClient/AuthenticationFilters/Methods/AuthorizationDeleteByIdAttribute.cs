using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AutoServiceShopClient.AuthorizationAttributes
{
    public class AuthorizationDeleteById : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("DeleteById").Value;
            string[] roleArr = roles.Split(", ");

            string token = context.HttpContext.Request.RouteValues["token"].ToString();

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

            AssignRoles(client, context, token).Wait();

            if (roleArr.Where(role => context.HttpContext.User.IsInRole(role)).Select(role => role).Count() == roleArr.Length)
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                        {{ "controller", "Auth" },
                        { "action", "LogInIndex" } });
            else
                return;

        }
        public async Task AssignRoles(HttpClient client, ActionExecutingContext context, string token)
        {
            HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/APISession/GetSessions");

            if (clientTask.IsSuccessStatusCode)
            {
                List<SessionAPI> sessions = JsonConvert.DeserializeObject<List<SessionAPI>>(await clientTask.Content.ReadAsStringAsync());

                long userId = sessions.Where(value => value.Token == token)
                        .Select(session => session.UserId).FirstOrDefault();

                clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/UserUserGroup/FindByField/UserId/{0}", userId));

                if (clientTask.IsSuccessStatusCode)
                {
                    List<UserUserGroup> groups = JsonConvert.DeserializeObject<List<UserUserGroup>>(await clientTask.Content.ReadAsStringAsync());

                    foreach (UserUserGroup group in groups)
                    {
                        context.HttpContext.User.AddIdentity(new ClaimsIdentity(new List<Claim>
                            {
                                new Claim(ClaimTypes.Role, group.UserGroupName)
                            }));
                    }
                }
            }
        }
    }
}
