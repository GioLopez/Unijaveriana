using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp3.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("All good my friend");
        }
    }
}
