﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp1.Controllers
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
                return Thankyou(user);
            }
            return View("Form");
        }

        private IActionResult Thankyou(User user)
        {
            TempData["Message"] = user.name;
            return View("Thankyou", user);
        }
    }
}