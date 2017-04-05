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

        [AllowAnonymous]
        [Route("tasks"), HttpGet]
        public IEnumerable<Task> GetAll()
        {           
            return taskService.GetAll(); ;
        }

        [AllowAnonymous]
        [Route("tasks/{id}"), HttpGet]
        public Task GetOne(long id)
        {
            return taskService.GetTaskById(id); ;
        }
    }
}
