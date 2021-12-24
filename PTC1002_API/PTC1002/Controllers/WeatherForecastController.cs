using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC1002.Controllers
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
        public IEnumerable<WeatherForecast> Get()
        {
           var t= System.IO.File.ReadAllText("MyTextFile.txt");
            //var guid = Guid.NewGuid();
            //var fileName = guid + ".txt";
            //string fullPath = "";
            //fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            //using (FileStream fileStream = new FileStream(fullPath, FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter file = new StreamWriter(fileStream, Encoding.UTF8))
            //    {
            //        file.WriteLine("your text here");
            //    }
            //}
            string[] lines = { "First line", "Second line", "Third line" };

            //string docPath =
            //  Environment.GetFolderPath(Directory.GetCurrentDirectory());

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "MyTextFile.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            //using (System.IO.StreamWriter file =
            //new System.IO.StreamWriter(System.IO.File.Create(fullPath).Dispose()))
            //{
            //    file.WriteLine("your text here");
            //}

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
