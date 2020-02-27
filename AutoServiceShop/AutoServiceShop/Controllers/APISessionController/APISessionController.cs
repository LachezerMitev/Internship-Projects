using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Session;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.IAPISessionController
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAPISession]
    public class APISessionController : ControllerBase, IAPISessionController
    {
        private readonly IsessionProcessor _processor;

        public APISessionController(IsessionProcessor processor)
        {
            _processor = processor;
        }

        /// <summary>
        /// Creates a session.
        /// </summary>   
        /// <response code="200">Item created</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Item right now</response>
        [HttpPost("CreateSession")]
        public IActionResult CreateSession(SessionParam param)
        {
            try
            {
                return Ok(_processor.CreateSession(HttpContext, param));
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Returns All Session.
        /// </summary>
        /// <response code="200">Items listed</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your Items right now</response>
        [HttpGet("GetSessions")]
        public IActionResult GetSessions()
        {
            try
            {
                return Ok(_processor.GetSessions());
            }
            catch
            {

                return BadRequest();
            }
        }
    }
}
