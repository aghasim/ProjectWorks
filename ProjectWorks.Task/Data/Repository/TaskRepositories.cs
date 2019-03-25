using ProjectWorks.Data.Abstractions;
using ProjectWorks.Task.Data.Models;
using System;

namespace ProjectWorks.Task.Data.Repository
{
    public class TaskRepositories : Repository<DataContext, MainTask, Guid>
    {
        public TaskRepositories(DataContext context) : base(context)
        {
        }
    }
}
