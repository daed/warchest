using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using War_chest.Models;

namespace War_chest.Controllers
{
    public class HomeController : BaseController
    {
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
                return View("Index");
            });
        }
    }
}
