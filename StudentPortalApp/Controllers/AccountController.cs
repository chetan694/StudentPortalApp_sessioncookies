using Microsoft.AspNetCore.Mvc;

namespace StudentPortalApp.Controllers
{
    public class AccountController : Controller
    {
        // GET Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST Login Form
        [HttpPost]
        public IActionResult Login(string username)
        {
            HttpContext.Session.SetString("UserName", username);

            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("UserName");

            ViewBag.User = user;

            return View();
        }
    }
}
