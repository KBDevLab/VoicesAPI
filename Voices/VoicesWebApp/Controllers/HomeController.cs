using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using VoicesWebApp.ViewModels;
using DataAccess.Models;
using System.Linq;
using System.Web;


namespace Voices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly voicesContext _ctx;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Dashboard()
        {
            if (/*["UserId"] != null*/true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

        //Get: Login
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {
            if (ModelState.IsValid)
            {
                var uLog = _ctx.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();

                if (uLog != null)
                {
                    /*Session["UserId"] = user.UserId.ToString();*/
                    return Ok(RedirectToAction("Dashboard", "Home"));
                }
                    
            }
            return View("Login", user);

        }


        public ActionResult LogOut()
        {
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
