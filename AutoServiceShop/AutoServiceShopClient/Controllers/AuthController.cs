using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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

       HttpClient client;

        public AuthController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;


            client = _clientFactory.CreateClient();
        }

        public IActionResult LogInIndex()
        {
            return View();
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
                    string txtBlock = await clientTask.Content.ReadAsStringAsync();

                    var tokenObject = JsonConvert.DeserializeObject<SessionAPI>(txtBlock);

                    client.DefaultRequestHeaders.Authorization = null;

                    Request.RouteValues["token"] = tokenObject.Token;

                    //return Redirect($"{tokenObject.Token}/Home/Index");
                    return RedirectToAction("Index", "Home", Request.RouteValues);
                }
                else
                    return View("LogInIndex", user);
            }
            catch(Exception e)
            {
                throw new Exception("An Error has occured" + e);
            }
        }

        [HttpGet]
        public async Task<IActionResult> LogOut(string token)
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
                    Request.RouteValues.Remove("token");
                    throw new Exception("An Error has occured");
                }
                    
            }
            catch (Exception e)
            {
                throw new Exception("An Error has occured" + e);
            }
        }


        
    }
}