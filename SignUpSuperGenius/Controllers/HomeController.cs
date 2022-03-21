using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignUpSuperGenius.Models;

namespace SignUpSuperGenius.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }

        
    }
}
