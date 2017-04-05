using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Api.Task.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private ApplicationDbContext dbContext;

        public TaskRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool CreateTask(Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
            return true;
        }

        public bool EditTask(Task task)
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