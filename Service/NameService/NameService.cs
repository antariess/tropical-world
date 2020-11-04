namespace Service
{
    public class NameService : INameService
    {
        public string GetGreeting(string name)
        {
            return $"hello {name}";
        }
    }
}
 