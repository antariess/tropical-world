using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace Service
{
    public class AnimalService : IAnimalService
    {

        private readonly IAnimalCollection _collection;

        public AnimalService(IAnimalCollection collection)
        {
            _collection = collection;
        }

        public async Task<IEnumerable<AnimalEntity>> GetAllAsync()
        {
            var entities = await _collection.GetAllAsync();
            return entities;
        }

        public async Task<AnimalEntity> InsertAsync(string name)
        {
            var entity = new AnimalEntity(name);

            await _collection.InsertAsync(entity);

            return entity;
        }
    }
}