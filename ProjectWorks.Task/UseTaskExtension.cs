using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.Task
{
    public static class UseTaskExtension
    {
        public static IApplicationBuilder UseTask(this IApplicationBuilder builder)
        {
            // Apply database migrations if any
            using (var context = new DataContextFactory().CreateDbContext(new String[] { }))
            {
                context.Database.Migrate();
            }

            return builder;
        }
    }
}
