using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Config;
using Data.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Data
{
    public class AnimalCollection : IAnimalCollection
    {
        private readonly IMongoCollection<AnimalEntity> _animalsCollection;

        public AnimalCollection(IMongoSettings settings)
        {
            var client = new MongoClient(BuildConnectionString(settings));
            var database = client.GetDatabase("TestDb");
            _animalsCollection = database.GetCollection<AnimalEntity>("Animals");
        }

        public async Task<IEnumerable<AnimalEntity>> GetAllAsync()
        {
            var filter = new BsonDocument();
            return await _animalsCollection.Find(filter).ToListAsync();
        }

        public async Task InsertAsync(AnimalEntity entity)
        {
            await _animalsCollection.InsertOneAsync(entity);
        }

        private string BuildConnectionString(IMongoSettings settings) => $"mongodb+srv://{settings.User}:{settings.Password}@cluster0.l5ap0.mongodb.net/{settings.DefaultDb}?retryWrites=true&w=majority";
    }
}
