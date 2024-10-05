using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatingApp.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DatingAppContext _context;
        public WeatherForecastController(DatingAppContext context)
        {
            _context=context;
        }
        //private static readonly string[] Summaries = new[]
        //{
          //  "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
          //  _logger = logger;
        //}

        //[HttpGet]
       // public IEnumerable<WeatherForecast> Get()
        //{
           // var rng = new Random();
           // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
           // {
             //   Date = DateTime.Now.AddDays(index),
               // TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            //})
           // .ToArray();
       // }
        [AllowAnonymous]
       [HttpGet]
       public async Task<IActionResult> GetValues(){
           var values= await _context.Value.ToListAsync();

            return Ok(values);
       }
       [AllowAnonymous]
       [HttpGet("{id}")]
       public async Task<IActionResult> GetValue(int id){
           var value= await _context.Value.FirstOrDefaultAsync(x=>x.Id==id);

           return Ok(value);
       }


    }
}
