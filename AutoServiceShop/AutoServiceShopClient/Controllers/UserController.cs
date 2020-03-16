using AutoServiceShopClient.AuthenticationFilters;
using AutoServiceShopClient.AuthorizationAttributes;
using AutoServiceShopClient.AuthorizationAttributes.Controllers;
using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Controllers
{
    [TokenConfirmationFilter]
    public class UserController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        private HttpClient client;

        public UserController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

            client = _clientFactory.CreateClient();
        }

        [AuthorizationCreate]
        public IActionResult CreateIndex()
        {
            return View("Create");
        }
        [AuthorizationUser]
        public IActionResult UserIndex()
        {
            return View("UserIndex");
        }
        [AuthorizationFindByPK]
        public IActionResult FindIndex()
        {
            return View("FindIndex", "0");
        }
        [AuthorizationUpdate]
        public IActionResult UpdateIndex()
        {
            return View("UpdateIndex");

        }

        [AuthorizationDeleteById]
        public async Task<IActionResult> DeleteIndex()
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/User/ListAll");

                if (clientTask.IsSuccessStatusCode)
                {

                    List<User> users = JsonConvert.DeserializeObject<List<User>>(await clientTask.Content.ReadAsStringAsync());

                    ViewBag.message = (users.Where(user => user.Active != 0).Select(user => user)).ToList(); ;

                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("DeleteIndex");
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

        [AuthorizationListAll]
        public async Task<IActionResult> ListAll()
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/User/ListAll");

                if (clientTask.IsSuccessStatusCode)
                {
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(await clientTask.Content.ReadAsStringAsync());

                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("ListAll", users);
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

        [AuthorizationCreate]
        public async Task<IActionResult> Create(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                user.Active = 1;

                HttpResponseMessage clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/User/Create/{param}", user);

                if (clientTask.IsSuccessStatusCode)
                {
                    string txtBlock = await clientTask.Content.ReadAsStringAsync();

                    var userObject = JsonConvert.DeserializeObject<User>(txtBlock);

                    long groupId = Convert.ToInt64(Request.Form["group"].ToString());

                    object userGroup = new { UserId = userObject.Id, UserGroupId = groupId, Active = 1 };

                    clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/UserUserGroup/Create/{param}", userGroup);

                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("ActionResult", "User was created");
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

        [AuthorizationUpdate]
        public async Task<IActionResult> UpdateInfo(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                long id = Convert.ToInt64(Request.Form["oldUserId"].ToString());

                HttpResponseMessage clientTask = await client.PutAsJsonAsync("https://localhost:44324/api/User/Update/" + id + "/{param}", user);

                if (clientTask.IsSuccessStatusCode)
                {
                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("ActionResult", "User was removed");
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

        [AuthorizationUpdate]
        public async Task<IActionResult> Update(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/User/FindByField/Username/{0}", user.Username));

                if (clientTask.IsSuccessStatusCode)
                {
                    string txtBlock = await clientTask.Content.ReadAsStringAsync();

                    List<User> usersFound = JsonConvert.DeserializeObject<List<User>>(txtBlock);

                    User userObject = usersFound.FirstOrDefault();

                    ViewBag.UserId = userObject.Id;

                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("UpdateInfoPage", userObject);
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

        [AuthorizationDeleteById]
        public async Task<IActionResult> Delete()
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                long id = Convert.ToInt64(Request.Form["Id"].ToString());

                HttpResponseMessage clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/UserUserGroup/FindByField/UserId/{0}", id));

                if (clientTask.IsSuccessStatusCode)
                {
                    List<UserUserGroup> userObject = JsonConvert.DeserializeObject<List<UserUserGroup>>(await clientTask.Content.ReadAsStringAsync());

                    foreach(UserUserGroup item in userObject)
                    {
                        clientTask = await client.DeleteAsync(string.Format("https://localhost:44324/api/UserUserGroup/DeleteById/{0}", item.Id.ToString()));
                    }

                    if (clientTask.IsSuccessStatusCode)
                    {

                        clientTask = await client.DeleteAsync(string.Format("https://localhost:44324/api/User/DeleteById/{0}", id));

                        if (clientTask.IsSuccessStatusCode)
                        {
                            client.DefaultRequestHeaders.Remove("AuthToken");

                            return View("ActionResult", "User was removed");

                        }
                        else
                        {
                            client.DefaultRequestHeaders.Remove("AuthToken");
                            return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                        }
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Remove("AuthToken");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                    }
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

        [AuthorizationFindByPK]
        public async Task<IActionResult> Find(string username)
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/User/FindByField/Username/{0}", username));

                if (clientTask.IsSuccessStatusCode)
                {
                    List<User> user = JsonConvert.DeserializeObject<List<User>>(await clientTask.Content.ReadAsStringAsync());

                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("FindResult", user.FirstOrDefault());
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
