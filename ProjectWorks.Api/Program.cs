using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.IO;

namespace ProjectWorks.Api
{
    public class Program
    {
        public static IConfiguration Configuration { get; private set; }


        public static void Main(String[] args)
        {
            // Get environment name
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

            // Build IConfiguration
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .Build();

            //Create and configure ILogger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();

            // Start hosting
            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }



        public static IWebHostBuilder CreateWebHostBuilder(String[] args)
        {
            // Create and return IWebHost
            return WebHost
                .CreateDefaultBuilder(args)
                .UseConfiguration(Configuration)
                .UseStartup<Startup>()
                .UseSerilog();
               
        }
    }
}
