using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using RestSharp;

namespace AutoServiceShopClient.Controllers
{
    
    public class AuthController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        private HttpClient client;

        public AuthController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;


            client = _clientFactory.CreateClient();
        }

        public IActionResult LogInIndex()
        {
            return View();
        }

        public IActionResult RegisterIndex()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(user.Username + ":" + user.Password)));

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/Auth/LogIn");

                if (clientTask.IsSuccessStatusCode)
                {
                    var tokenObject = JsonConvert.DeserializeObject<SessionAPI>(await clientTask.Content.ReadAsStringAsync());

                    client.DefaultRequestHeaders.Authorization = null;
                    client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

                    clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/User/FindByField/Username/{0}", user.Username));

                    if (clientTask.IsSuccessStatusCode)
                    {
                        List<User> users = JsonConvert.DeserializeObject<List<User>>(await clientTask.Content.ReadAsStringAsync());

                        if(users.FirstOrDefault().Active != 0)
                        {
                            clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/UserUserGroup/FindByField/UserId/{0}", users.FirstOrDefault().Id));
                            
                            if (clientTask.IsSuccessStatusCode)
                            {
                                List<UserUserGroup> groups = JsonConvert.DeserializeObject<List<UserUserGroup>>(await clientTask.Content.ReadAsStringAsync());


                                client.DefaultRequestHeaders.Authorization = null;

                                Request.RouteValues["token"] = tokenObject.Token;

                                if (groups.FindIndex(item => item.UserGroupName == "Admin") >= 0)
                                    return RedirectToAction("Index", "Home", Request.RouteValues);
                                else
                                    return RedirectToAction("UserHome", "Home", Request.RouteValues);
                            }
                            else
                            {
                                client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                                return View("ErrorHandlerPage", "The User has been deleted or is inactive");
                            }
                        }
                        else
                        {
                            client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                            return View("ErrorHandlerPage", "The User has been deleted or is inactive");
                        }
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                    }
                }
                else
                {
                    client.DefaultRequestHeaders.Remove("Basic");
                    return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                }

            }
            catch(Exception e)
            {
                client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                return View("ErrorHandlerPage", e.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");
                user.Active = 1;

                HttpResponseMessage clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/User/Create/{param}", user);

                if (clientTask.IsSuccessStatusCode)
                {
                    string txtBlock = await clientTask.Content.ReadAsStringAsync();

                    var userObject = JsonConvert.DeserializeObject<User>(txtBlock);

                    long groupId = Convert.ToInt64(Request.Form["group"].ToString());

                    object userGroup = new { UserId = userObject.Id, UserGroupId = groupId, Active = 1 };

                    clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/UserUserGroup/Create/{param}", userGroup);

                    if (clientTask.IsSuccessStatusCode)
                    {
                        ViewBag.UserId = userObject.Id;
                        return View("AccountRegister");
                    }
                    else
                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                }
                else
                    return View("LogInIndex", user);
            }
            catch (Exception e)
            {
                client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                return View("ErrorHandlerPage", e.ToString());
            }
        }

        public async Task<IActionResult> AccountRegister(Account account)
        {
            try
            {
                client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

                account.Active = 1;
                account.AccountStatusId = 1;
                account.AccountTypeId = Convert.ToInt64(Request.Form["type"].ToString());
                account.UserId = Convert.ToInt64(Request.Form["userId"].ToString());
                account.Code = account.Id.ToString();
                account.Description = account.FirstName + account.Surname + account.LastName;
                account.Name = account.LastName;

                HttpResponseMessage clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/Account/Create/{param}", account);
                
                if (clientTask.IsSuccessStatusCode)
                {
                    client.DefaultRequestHeaders.Remove("ClientAssignAdmin");

                    return View("LogInIndex");
                }
                else
                {
                    client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                    return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                }
            }
            catch (Exception e)
            {
                client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                return View("ErrorHandlerPage", e.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/Auth/LogOut");

                if (clientTask.IsSuccessStatusCode)
                {
                    client.DefaultRequestHeaders.Remove("AuthToken");

                    Request.RouteValues.Remove("token");

                    return RedirectToAction("LogInIndex", "Auth");
                }
                else
                {
                    client.DefaultRequestHeaders.Remove("AuthToken");
                    return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                }
                    
            }
            catch (Exception e)
            {
                client.DefaultRequestHeaders.Remove("AuthToken");
                return View("ErrorHandlerPage", e.ToString());
            }
        }

    }
}