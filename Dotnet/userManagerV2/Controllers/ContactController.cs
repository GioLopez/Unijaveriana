using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using userManagerV2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace userManagerV2.Controllers
{
    //[Route("[controller]/[action]")]
    public class ContactController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                return Thankyou(user);
            }
            TempData["Message"] = user.Name;
            return Form();
        }

        private IActionResult Thankyou(User user)
        {
            TempData["Message"] = user.Name;
            return View("Thankyou", user);
        }
    }
}
