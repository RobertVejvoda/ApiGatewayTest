using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Black Tea", "Green Tea", "White Tea", "Oolong Tea", "Pu-erh Tea", "Purple Tea", "Herbal Infusions"
        };

        private readonly ILogger<TeaController> _logger;

        public TeaController(ILogger<TeaController> logger)
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
