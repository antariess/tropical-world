using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Requests;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;

namespace TropicalWorld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly ILogger<AnimalsController> _logger;

        private readonly IAnimalService _service;

        public AnimalsController(ILogger<AnimalsController> logger, IAnimalService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<AnimalEntity>> GetAll()
        {
            var response = await _service.GetAllAsync();
            return response;
        }

        [HttpPost]
        public async Task<AnimalEntity> Post([FromBody] NewAnimalRequest req)
        {
            var response = await _service.InsertAsync(req.Name);
            return response;
        }
    }
}
