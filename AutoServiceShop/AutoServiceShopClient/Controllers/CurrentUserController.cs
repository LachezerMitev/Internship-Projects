using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoServiceShopClient.AuthenticationFilters;
using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoServiceShopClient.Controllers
{
    [TokenConfirmationFilter]
    public class CurrentUserController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        private HttpClient client;

        public CurrentUserController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

            client = _clientFactory.CreateClient();
        }

        public IActionResult DeleteIndex()
        {
            return View("DeleteIndex");
        }
        public IActionResult UpdateIndex()
        {
            ViewBag.UserId = Request.Form["UserId"];
            return View("UpdateIndex");
        }
        public async Task<IActionResult> CurrentUserIndex()
        {
            try
            {
                client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/APISession/GetSessions");

                if (clientTask.IsSuccessStatusCode)
                {

                    List<SessionAPI> sessions = JsonConvert.DeserializeObject<List<SessionAPI>>(await clientTask.Content.ReadAsStringAsync());

                    long userId = sessions.Where(value => value.Token == Request.RouteValues["token"].ToString())
                        .Select(session => session.UserId).FirstOrDefault();

                    clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/User/FindByPK/{0}", userId));
                    if (clientTask.IsSuccessStatusCode)
                    {
                        User user = JsonConvert.DeserializeObject<User>(await clientTask.Content.ReadAsStringAsync());

                        ViewBag.UserId = user.Id;

                        return View("CurrentUserIndex", user);
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                    }
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

        public async Task<IActionResult> Delete(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

                HttpResponseMessage clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/User/FindByField/Username/{0}", user.Username));
                
                if (clientTask.IsSuccessStatusCode)
                {
                    List<User> userExisting = JsonConvert.DeserializeObject<List<User>>(await clientTask.Content.ReadAsStringAsync());
                    user.Id = userExisting.FirstOrDefault().Id;

                    clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/UserUserGroup/FindByField/UserId/{0}", user.Id));

                    if (clientTask.IsSuccessStatusCode)
                    {
                        List<UserUserGroup> userObject = JsonConvert.DeserializeObject<List<UserUserGroup>>(await clientTask.Content.ReadAsStringAsync());

                        foreach (UserUserGroup item in userObject)
                        {
                            clientTask = await client.DeleteAsync(string.Format("https://localhost:44324/api/UserUserGroup/DeleteById/{0}", item.Id.ToString()));
                        }

                        if (clientTask.IsSuccessStatusCode)
                        {

                            clientTask = await client.DeleteAsync(string.Format("https://localhost:44324/api/User/DeleteById/{0}", user.Id));

                            if (clientTask.IsSuccessStatusCode)
                            {
                                clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/Account/FindByField/UserId/{0}", user.Id));

                                if (clientTask.IsSuccessStatusCode)
                                {
                                    List<Account> users = JsonConvert.DeserializeObject<List<Account>>(await clientTask.Content.ReadAsStringAsync());

                                    foreach (Account item in users)
                                    {
                                        clientTask = await client.DeleteAsync(string.Format("https://localhost:44324/api/Account/DeleteById/{0}", item.Id.ToString()));
                                    }
                                    if (clientTask.IsSuccessStatusCode)
                                    {
                                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");

                                        return View("SelfDelete", "User was removed");
                                    }
                                    else
                                    {
                                        client.DefaultRequestHeaders.Remove("Register");
                                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                                    }
                                }
                                else
                                {
                                    client.DefaultRequestHeaders.Remove("Register");
                                    return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                                }
                            }
                            else
                            {
                                client.DefaultRequestHeaders.Remove("Register");
                                return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                            }
                        }
                        else
                        {
                            client.DefaultRequestHeaders.Remove("Register");
                            return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                        }
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Remove("Register");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                    }
                }
                else
                {
                    client.DefaultRequestHeaders.Remove("Register");
                    return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                }
            }
            catch (Exception e)
            {
                client.DefaultRequestHeaders.Remove("AuthToken");
                return View("ErrorHandlerPage", e.ToString());
            }

        }

        public async Task<IActionResult> Update(Account account)
        {
            try
            {
                client.DefaultRequestHeaders.Add("ClientAssignAdmin", "");

                long id = Convert.ToInt64(Request.Form["UserId"].ToString());

                account.Active = 1;
                account.AccountStatusId = 1;
                account.AccountTypeId = Convert.ToInt64(Request.Form["type"].ToString());
                account.Code = account.Id.ToString();
                account.Description = account.FirstName + account.Surname + account.LastName;
                account.Name = account.LastName;

                HttpResponseMessage clientTask = await client.GetAsync(string.Format("https://localhost:44324/api/Account/FindByField/UserId/{0}", id));

                if (clientTask.IsSuccessStatusCode)
                {
                    List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(await clientTask.Content.ReadAsStringAsync());

                    long currentAccountId = accounts.Where(item => item.Id == id).Select(item => item.Id).FirstOrDefault();

                    clientTask = await client.PutAsJsonAsync("https://localhost:44324/api/Account/Update/" + currentAccountId + "/{param}", account);

                    if (clientTask.IsSuccessStatusCode)
                    {
                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");

                        return View("SelfDelete", "User was Updated");
                    }
                    else
                    {
                        client.DefaultRequestHeaders.Remove("ClientAssignAdmin");
                        return View("ErrorHandlerPage", clientTask.StatusCode.ToString());
                    }
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
    }
}