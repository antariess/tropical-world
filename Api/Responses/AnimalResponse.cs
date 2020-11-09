using System;

namespace Api.Responses
{
    public class AnimalResponse
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public bool IsRecent { get; set; }
    }
}
