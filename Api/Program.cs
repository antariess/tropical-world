using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TropicalWorld
{
    public class Program
    {
        public static void Main(string[] args) // entry point
        {
            CreateHostBuilder(args).Build().Run(); // initiate a server
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // and make it listen
                });
    }
}
