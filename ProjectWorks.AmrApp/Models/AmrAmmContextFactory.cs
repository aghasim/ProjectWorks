using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.AmrApp.Models
{
    public class AmrAmmContextFactory:IDesignTimeDbContextFactory<aspnetsmrContext>
    {
        private readonly IChangeConnectionString connectionString;
        public AmrAmmContextFactory(IChangeConnectionString connectionString)
        {
            this.connectionString = connectionString;
        }
        public aspnetsmrContext CreateDbContext(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //   .SetBasePath(AppContext.BaseDirectory)
            //   .AddJsonFile("appsettings.json")
            //   .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
            //   .Build();

            //var builder = new DbContextOptionsBuilder<aspnetsmrContext>()
            //    .UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new aspnetsmrContext();
        }




        public aspnetsmrContext GetDbContext(string connString = null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<aspnetsmrContext>()
                .UseSqlServer(configuration.GetConnectionString(connString));

            return new aspnetsmrContext(builder.Options);
        }
    }
}
