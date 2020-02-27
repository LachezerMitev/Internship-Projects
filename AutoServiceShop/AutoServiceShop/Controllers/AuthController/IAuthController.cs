using AutoServiceShop.Business.Processor.Converter.Session;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.OutController
{
    public interface IAuthController
    {
        IActionResult LogIn();

        IActionResult LogOut();
    }
}
