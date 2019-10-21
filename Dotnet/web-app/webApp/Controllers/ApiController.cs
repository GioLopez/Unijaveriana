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
        public IActionResult UserInfo(int id)
        {
            
            var output = Sqlconnection.LoadUsers(id).ToList();
            
            if (output.Count() == 0)
            {
                return NotFound();
            }

            return Ok(output);
        }

        [HttpPost]
        public IActionResult UserInfo([FromBody]User user)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var executed = Sqlconnection.SaveUser(user);
            if (executed)
            {
                return Ok();
            }else {
                return BadRequest();
            }
        }

        private IActionResult CreatedResult(string v)
        {
            throw new NotImplementedException();
        }
    }
}
