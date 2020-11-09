using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Requests;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Api.Responses;

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
        public async Task<IEnumerable<AnimalResponse>> GetAllAsync()
        {
            var response = await _service.GetAllAsync();
            var ordered = response.OrderBy(animal => animal.Added); // animal as AnimalResponse
            var cast = ordered.Select(animal => {
           
                    var castAnimal = (AnimalResponse)animal;
                    return castAnimal;
               
            });
            return cast;
        }

        [HttpPost]
        public async Task<AnimalEntity> PostAsync([FromBody] NewAnimalRequest req)
        {
            var response = await _service.InsertAsync(req.Name);
            return response;
        }

        //[HttpGet]
        ////[Route("one")]
        //public Task GetOneAsync(Guid animalId)
        //{
        //    return Task.CompletedTask;
        //}
    }
}
