using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreApiReadAppSettings.Models;
using Microsoft.Extensions.Options;

namespace CoreApiReadAppSettings.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IOptions<MySettingsModel> appSettings;

        public StudentController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var dbValue = appSettings.Value.DbConnection;
            var list = new List<string>();
            list.Add("John");
            list.Add("Doe");
            return Ok(list);
        }
    }
}
