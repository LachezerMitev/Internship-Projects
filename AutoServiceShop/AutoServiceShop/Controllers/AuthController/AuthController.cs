using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.OutProcessor;
using AutoServiceShop.Business.Processor.Session;
using AutoServiceShop.Controllers.CommonController;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.OutController
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase, IAuthController
    {
        private readonly IAuthProcessor _processor;

        public AuthController(IAuthProcessor processor)
        {
            _processor = processor;
        }

        /// <summary>
        /// Log In.
        /// </summary>
        /// <response code="200">Item created</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Item right now</response>
        [HttpGet("LogIn")]
        public IActionResult LogIn()
        {
            try
            {
                return Ok(_processor.CreateSession(HttpContext));
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Log out.
        /// </summary>
        /// <response code="200">Session Deleted</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Item right now</response>
        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {
            try
            {
                _processor.RemoveSession(HttpContext);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
