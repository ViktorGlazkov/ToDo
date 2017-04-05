using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDo.Api.Task.Repository;

namespace ToDo.Api.Task.Service
{
    public class TaskService : ITaskService
    {
        private ITaskRepository TaskRepository;
        public bool CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTask(long id)
        {
            throw new NotImplementedException();
        }

        public bool EditTask(Task task)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAll()
        {
            TaskRepository = new TaskRepository(new ApplicationDbContext());
            return TaskRepository.GetAll();
        }

        public Task GetTaskById(long id)
        {
            throw new NotImplementedException();
        }
    }
}