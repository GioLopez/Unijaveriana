using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManage.Models;

namespace UserManage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var allUsers = new List<theUser>
                {
                    new theUser { Id = 1, Email = "giovannt_92@hotmail.com", Name = "Giovanni", Message = "You rock", Phone = ""},
                    new theUser { Id = 2, Email = "gioipez92@gmail.com", Name = "Enrique", Message = "You rock!", Phone = "3106530101"},
                    new theUser { Id = 3, Email = "lopezge@javeriana.edu.co", Name = "Lopez", Message = "You double rock", Phone = ""},
                };
            return View(allUsers);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }

            TempData["Message"] = $"Thank you. User: {formData.Name} was created!";
            return RedirectToAction("Thanks");

            //return Json(formData);
            //return View();
        }

        public IActionResult Thanks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public class theUser
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
            public string Phone { get; set; }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
