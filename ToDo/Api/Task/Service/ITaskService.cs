using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Api.Task.Service
{
    public interface ITaskService
    {
        List<Task> GetAll();
        Task GetTaskById(long id);
        bool EditTask(Task task);
        bool DeleteTask(long id);
        bool CreateTask(Task task);
    }
}