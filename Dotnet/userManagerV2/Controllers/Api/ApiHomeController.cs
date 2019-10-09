using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using userManagerV2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace userManagerV2.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class ApiHomeController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void CreateUser([FromBody]User user)
        {
        }

   
    }
}
