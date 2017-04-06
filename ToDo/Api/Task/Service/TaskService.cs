using System;
using System.Collections.Generic;
using ToDo.Api.Task.Repository;

namespace ToDo.Api.Task.Service
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void CreateTask(Task task)
        {
            taskRepository.CreateTask(task);
        }

        public void DeleteTask(long id)
        {
            var task = GetTaskById(id);
            taskRepository.DeleteTask(task);
        }

        public void EditTask(Task task)
        {
            taskRepository.EditTask(task);
        }

        public List<Task> GetAll()
        {            
            return taskRepository.GetAll();
        }

        public Task GetTaskById(long id)
        {
            return taskRepository.GetTaskById(id);
        }
    }
}