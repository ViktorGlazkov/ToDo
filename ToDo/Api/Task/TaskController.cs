using Autofac.Integration.WebApi;
using System.Collections.Generic;
using System.Web.Http;
using ToDo.Api.Task;
using ToDo.Api.Task.Service;

namespace ToDo.Controllers
{
    [Authorize]
    [RoutePrefix("api")]
    [AutofacControllerConfiguration]
    public class TaskController : ApiController
    {        
        private ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }
        
        [Route("tasks"), HttpGet]
        public IEnumerable<Task> GetAll()
        {           
            return taskService.GetAll(); ;
        }
        
        [Route("tasks/{id}"), HttpGet]
        public Task GetOne(long id)
        {
            return taskService.GetTaskById(id); ;
        }

        [Route("tasks"), HttpPut]
        public void Create(Task task)
        {
            taskService.CreateTask(task); 
        }

        [Route("tasks"), HttpPost]
        public void Edit(Task task)
        {
            taskService.EditTask(task);
        }

        [Route("tasks/{id}"), HttpDelete]
        public void Delete(long id)
        {
            taskService.DeleteTask(id);
        }
    }
}
