using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    public interface IAnimalCollection
    {
        Task<IEnumerable<AnimalEntity>> GetAllAsync();

        Task InsertAsync(AnimalEntity entity);
    }
}
