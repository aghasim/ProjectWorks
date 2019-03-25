using ProjectWorks.Data.Resources;
using ProjectWorks.Task.Data.Models;
using ProjectWorks.Task.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorks.Task.Services
{
    public class TasksServices
    {
        private readonly TaskRepositories repositories;

        public TasksServices(TaskRepositories repositories)
        {
            this.repositories = repositories;
        }


        public async Task<IEnumerable<MainTask>> GetAll(ResourceParameters parameters = null)
        {
            return await this.repositories.GetAll(parameters);
        }

        public async Task<MainTask> Get(Expression<Func<MainTask, Boolean>> predicate)
        {
            return await this.repositories.Get(predicate);
        }



        public async Task<MainTask> Get(Guid id)
        {
            return await this.repositories.Get(id);
        }


        public async Task<MainTask> Create(MainTask model)
        {
            return await this.repositories.Create(model);
        }



        public async Task<MainTask> Update(MainTask model)
        {
            return await this.repositories.Update(model);
        }



        public async Task<MainTask> Delete(Guid id)
        {
            return await this.repositories.Delete(id);
        }

    }
}
