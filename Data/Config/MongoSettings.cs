namespace Data.Config

// could implement IMongoSettings with a keyvault service in future

{
    public class MongoSettings : IMongoSettings
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string DefaultDb  { get; set; } = "TestDb";
    }

    public interface IMongoSettings
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string DefaultDb { get; set; }
    }
}
