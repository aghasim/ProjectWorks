using Microsoft.EntityFrameworkCore;
using ProjectWorks.Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.Task
{
    public class DataContext : DbContext
    {
        public DbSet<MainTask> MainTasks { get; set; }
        public DbSet<NestedTask> NestedTasks { get; set; }


        public DataContext()
        {
        }



        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MainTask>(entity => {
                entity.ToTable("ProjectWorks_MainTask");
                entity.HasIndex(m => m.Id).IsUnique();
            });

            builder.Entity<NestedTask>(entity => {
                entity.ToTable("ProjectWorks_NestedTask");
                entity.HasIndex(m => m.Id).IsUnique();
            });

            builder.Entity<MainTask>()
                .HasMany(m => m.NestedTasks)
                .WithOne(m => m.MainTask)
                .HasForeignKey(m => m.MainTaskId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<NestedTask>()
                .HasOne(m => m.MainTask)
                .WithMany(m => m.NestedTasks)
                .HasForeignKey(m => m.Id)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
