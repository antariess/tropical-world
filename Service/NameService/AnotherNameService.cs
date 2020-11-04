namespace Service
{
    public class AnotherNameService : INameService
    {
        public string GetGreeting(string name)
        {
            return "something else";
        }
    }
}
