using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using War_chest.Models;

namespace War_chest.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IConfiguration _config) : base(_config)
        { }

        public ActionResult Index()
        {
            return HandleExceptions(() =>
            {
                return View();
            });
        }

        public ActionResult Privacy()
        {
            return HandleExceptions(() =>
            {
                return View();
            });
        }

        public ActionResult Login()
        {
            return HandleExceptions(()=> 
            {
                var model = new UserViewModel();
                return View(model);
            });
        }
        [HttpPost]
        public ActionResult Login(UserViewModel model)
        {
            return HandleExceptions(() => 
            {
                var dbUser = DB.Users.Find(model.UserName);

                if (dbUser.UserName == model.UserName)
                    ;

                return View("Index");
            });
        }
    }
}
