using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectWorks.AmrApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.AmrApp
{
    public static class AddAmrAppExtension
    {
        public static IServiceCollection AddAmrApp(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>();

            services.AddScoped<IChangeConnectionString, GetConnectionStringService>();
            // Configure IOptions

            // Register databse context
            //services.AddDbContext<aspnetsmrContext>(builder =>
            //{
            //    builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //});
            services.AddScoped<AmrAmmContextFactory>();
            // Register module providers

            // Register module services
            
            // Register module repositories
            return services;
        }
    }
}
