using Homeo_mgt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homeo_mgt.Controllers
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

        public IActionResult Login() 
        {
            return View();
        }

       
    }
}