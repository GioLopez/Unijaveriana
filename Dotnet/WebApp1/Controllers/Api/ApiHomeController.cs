using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp1.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class ApiHomeController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody]User user)
        {

            if (ModelState.IsValid)
            {
                return CreatedAtAction(nameof(CreateUser), user);
            }
            return BadRequest("Invalid Body Parameters!");
        }


    }
}