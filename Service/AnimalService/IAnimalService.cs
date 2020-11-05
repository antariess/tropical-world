using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Service
{
    public interface IAnimalService
    {
        Task<IEnumerable<AnimalEntity>> GetAllAsync();

        Task<AnimalEntity> InsertAsync(string name);
    }
}
