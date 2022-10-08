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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel) 
        {
            try
            {
                if (loginModel != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            { 
                throw;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Registration() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationModel registrationModel) 
        {
            try
            {
                if (registrationModel != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return View();
        }       
    }
}