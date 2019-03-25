using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectWorks.AmrApp;
using ProjectWorks.Task.Data.Repository;
using ProjectWorks.Task.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.Task
{
    public static class AddTaskExtension
    {
        public static IServiceCollection AddTask(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>();

            // Configure IOptions

            // Register databse context
            services.AddDbContext<DataContext>(builder =>
            {
                builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            // Register module providers
            services.AddAmrApp();
            // Register module services
            services.AddScoped<TasksServices>();
            // Register module repositories
            services.AddScoped<TaskRepositories>();
            services.AddScoped<AmrAppRepository>();
            return services;
        }
    }
}
