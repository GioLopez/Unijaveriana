using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApp.Controllers
{
    public class ApiController : Controller
    {


        [HttpGet]
        public IActionResult UserInfo()
        {
            return Ok("Done!\n");
        }

        [HttpPost]
        public User UserInfo([FromBody]User user)
        {
            return user;
        }
    }
}
