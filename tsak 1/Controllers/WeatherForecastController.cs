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
       
        [HttpGet]
        public double GetVolume(double a,double b,double c)
        {
            _logger.LogInformation("BRAT tva raboti");
            double result = a * b * c;
            return result;
        }
        [HttpPost]
        public people_info People(people_info a)
        {

            return a;
        }


    }
}
