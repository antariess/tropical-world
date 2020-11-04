//using System.Threading.Tasks; ----> when we get round to async
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;

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
        private readonly ILogger<CatsController> _logger;

        private readonly INameService _service;

        public CatsController(ILogger<CatsController> logger, INameService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public string Get()
        {
            return "hello, Xav!";
        }

        [HttpPost]
        public string Post([FromBody] Req req)
        {
            var response = _service.GetGreeting(req.name);

            return response;
        }
    }
}
