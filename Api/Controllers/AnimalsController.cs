using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Requests;
using Api.Responses;
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
        public async Task<IEnumerable<AnimalResponse>> GetAll()
        {
            var entities = await _service.GetAllAsync();
            return entities.Select(x => MapToResponse(x));
        }

        [HttpPost]
        public async Task<AnimalEntity> Post([FromBody] NewAnimalRequest req)
        {
            var response = await _service.InsertAsync(req.Name);
            return response;
        }

        // this would live in a helper class
        private AnimalResponse MapToResponse(AnimalEntity entity)
        {
            return new AnimalResponse
            {
                Name = entity.Name,
                Id = entity.Id,
                IsRecent = entity.Added > DateTime.Parse("2020-10-31"),
            };
        }
    }
}
