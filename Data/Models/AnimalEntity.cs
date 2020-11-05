using System;

namespace Data.Models
{
    public class AnimalEntity
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public DateTime Added { get; set; }

        public AnimalEntity(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Added = DateTime.UtcNow;
        }
    }
}
