using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Espresso", "Long Black", "Doppio", "Ristreto", "Short Macchiato", "Mezzo Mezzo", "Cappuccino"
        };

        private readonly ILogger<CoffeeController> _logger;

        public CoffeeController(ILogger<CoffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Summaries[rng.Next(Summaries.Length)]);
        }
    }
}
