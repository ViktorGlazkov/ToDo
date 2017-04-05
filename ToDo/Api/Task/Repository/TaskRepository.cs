using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo.Api.Task.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private ApplicationDbContext dbContext;

        public TaskRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateTask(Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();           
        }

        public void DeleteTask(long id)
        {
            dbContext.Tasks.Remove(GetTaskById(id));
            dbContext.SaveChanges();
        }

        public void EditTask(Task task)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAll()
        {
            return dbContext.Tasks.ToList();
        }

        public Task GetTaskById(long id)
        {
            return dbContext.Tasks.Find(id);
        }
    }
}