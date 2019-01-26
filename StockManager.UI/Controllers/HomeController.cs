using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockManager.UI.Models;
using Microsoft.AspNetCore.Identity;
using StockManager.Data.Data.Entities;

namespace StockManager.UI.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<User> _signInManager;
        public HomeController(SignInManager<User> signInMgr)
        {
            _signInManager = signInMgr;   
        }

        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
