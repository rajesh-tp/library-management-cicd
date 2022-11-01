using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Library.Models;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        static IList<User> userList = new List<User>{
                new User() { UserId = 1, UserName = "admin", Password ="admin", IsAdmin = true } ,
                new User() { UserId = 2, UserName = "Rajesh", Password ="rajesh123", IsAdmin = false } ,
            };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "End to end library management system.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }        
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var result = userList.Where(u => u.UserName == user.UserName && u.Password == user.Password);
                if (result.Any())
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index");
                }                
                ModelState.AddModelError("invaliduser", "Invalid username or password.");
            }
            return View(user);
        }
    }
}