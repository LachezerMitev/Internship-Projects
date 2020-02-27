using AutoServiceShopClient.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        private HttpClient client;

        public UserController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

            client = _clientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> ListAll()
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.GetAsync("https://localhost:44324/api/User/ListAll");

                if (clientTask.IsSuccessStatusCode)
                {

                    string txtBlock = await clientTask.Content.ReadAsStringAsync();

                    List<User> users = JsonConvert.DeserializeObject<List<User>>(txtBlock);

                    client.DefaultRequestHeaders.Authorization = null;


                    return View("ListAll", users);
                }
                else
                    return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                throw new Exception("An Error has occured" + e);
            }
        }

        [HttpPost]
        public IActionResult CreateIndex(User user)
        {
            return View("Create");
        }

        public async Task<IActionResult> Create(User user)
        {
            try
            {
                client.DefaultRequestHeaders.Add("AuthToken", "Token " + Request.RouteValues["token"]);

                HttpResponseMessage clientTask = await client.PostAsJsonAsync("https://localhost:44324/api/User/Create", user);

                if (clientTask.IsSuccessStatusCode)
                {
                    client.DefaultRequestHeaders.Remove("AuthToken");

                    return View("CreateResult", "Item Was created");
                }
                else
                {
                    client.DefaultRequestHeaders.Remove("AuthToken");
                    return View("CreateResult", "Item Was NOT created");
                }
                    
            }
            catch (Exception e)
            {
                throw new Exception("An Error has occured" + e);
            }
        }
    }
}
