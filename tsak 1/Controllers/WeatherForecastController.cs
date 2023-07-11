using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tsak_1.Models;

namespace tsak_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok();
        //}

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(string id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(PeopleInfo model)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(string id, PeopleInfo model)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok(id);
        }


    }
}
