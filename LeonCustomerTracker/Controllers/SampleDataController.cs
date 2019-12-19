using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LeonCustomerTracker.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        private readonly IConfiguration _config;

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // NZ...
        // Constructor automatically created if ommited. 
        // You can inject your database into the constructor and save it to the props or you can inject it into each controller as singleton.
        public SampleDataController(IConfiguration config)
        {
            _config = config;
        }


        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
        // ! Sample
        //[HttpPost("[action]")]
        //public void AddClient([FromBody] ClientDetailsDto clientData) // ! Set Type on front and backend
        //{
        //    // init cache variable
        //    var result = new Client();
        //    // fillter error check

        //    // the work
        //    result.first_name = clientData.firstName
        //    _db.Add(result);
        //    _db.SaveChanges();

        //    // return if any
        //}


        // ! Sample Config key
        //public void GetTest()
        //{
        //    var x = _config["YourKey"];
        //}
    }
}
