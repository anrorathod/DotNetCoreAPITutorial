using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDotNetCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Country>> GetCountryList()
        {
            List<Country> countries  = new List<Country>()
            {
                new Country{ Id = 1, Name = "India" , Code = "IN" },
                new Country{ Id = 2, Name = "USA" , Code = "US" } 
            };
            return countries;
        }
    }
}