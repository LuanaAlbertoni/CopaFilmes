using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CopaFilmes
{
    public class Program
    {
        public int escolher;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
