using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks; ----> when we get round to async
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TropicalWorld.Controllers
{
    public class Req
    {
        public string name { get; set; }
    }
    [ApiController]
    [Route("[controller]")]
    public class CatsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CatsController> _logger;

        public CatsController(ILogger<CatsController> logger) => _logger = logger;

        [HttpGet]
        public string Get()
        {
            //var rng = new Random();
            return "hello, Xav!";
        }
        [HttpPost]
        public string Post([FromBody] Req req)
        {

            return $"Hello, {req.name}";
        }
    }
}
