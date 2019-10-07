using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManage.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManage.Controllers
{
    public class ApiHomeController : Controller
    {
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Wrong Parameters, please check and try again!");

                //TempData["Message"] = "Error, wrong parameters";
                //return View();

                //return NotFound("Wrong parameters!");
            }
            return CreatedAtAction(nameof(CreateUser), new { id = user.Id }, user);
        }
    }
}
