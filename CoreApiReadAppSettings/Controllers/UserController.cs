using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CoreApiReadAppSettings.Controllers
{
    [Produces("application/json")]
    //[Route("api/[controller]")]
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration configuration;

        public UserController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            //method 1
            string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;

            //method 2
            string dbConn2 = configuration.GetValue<string>("MySettings:MySettings");

            var list = new List<string>();
            list.Add("John");
            list.Add("Doe");
            return Ok(list);
        }
    }
}
