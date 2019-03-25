using Microsoft.AspNetCore.Mvc;
using ProjectWorks.AmrApp;
using ProjectWorks.AmrApp.Models;
using ProjectWorks.Task.Data.Models;
using ProjectWorks.Task.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWorks.Task.Controllers
{
    [Route("api/tasks")]
    public class TasksController : Controller
    {
        private readonly TasksServices tasksServices;
        private readonly AmrAppRepository amrAppRepository;

        public TasksController(TasksServices tasksServices, AmrAppRepository amrAppRepository)
        {
            this.tasksServices = tasksServices;
            this.amrAppRepository = amrAppRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            return this.Ok(await this.tasksServices.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Int32 id)
        {
            this.amrAppRepository.SetConnString(id);
            var user = this.amrAppRepository.context.AppUsers.Where(x=>x.UserName== "6195").FirstOrDefault();
            return this.Ok(user);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] MainTask model)
        {
            return this.Ok("TaskController.Create(model)");
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(Int32 id, [FromBody] MainTask model)
        {
            return this.Ok("TaskController.Update(id, model)");
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Int32 id)
        {
            return this.Ok("TaskController.Delete(id)");
        }
    }
}
