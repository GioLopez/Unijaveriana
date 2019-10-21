using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApp.Controllers
{
    //[Route("[controller]/[action]")]
    [Authorize]
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
                var executed = Sqlconnection.SaveUser(user);
                if (executed)
                {
                    return Thankyou(user);
                }
                else
                {
                    return BadRequest();
                }
            }
            return View("Form");
        }

        private IActionResult Thankyou(User user)
        {
            TempData["Message"] = user.Name;
            return View("Thankyou", user);
        }
    }
}