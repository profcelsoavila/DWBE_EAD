using Exemplo3;

namespace Exemplo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            //evita a exceção de banco de dados inexistente
            .UseDefaultServiceProvider(options => options.ValidateScopes = false);
    }
}
