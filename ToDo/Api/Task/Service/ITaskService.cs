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
        void EditTask(Task task);
        void DeleteTask(long id);
        void CreateTask(Task task);
    }
}