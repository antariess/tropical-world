using System.ComponentModel.DataAnnotations;

namespace Api.Requests
{
    public class NewAnimalRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
