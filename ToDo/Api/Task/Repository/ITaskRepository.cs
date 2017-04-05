using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Api.Task.Repository
{
    public interface ITaskRepository
    {
        List<Task> GetAll();
        Task GetTaskById(long id);
        bool EditTask(Task task);
        bool CreateTask(Task task);
    }
}