using System.Collections.Generic;

namespace ToDo.Api.Task.Repository
{
    public interface ITaskRepository
    {
        List<Task> GetAll();
        Task GetTaskById(long id);
        void EditTask(Task task);
        void CreateTask(Task task);
        void DeleteTask(Task task);
    }
}