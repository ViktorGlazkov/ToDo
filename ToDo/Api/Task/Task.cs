using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Api.Task
{
    [Table("task")]
    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Task() {}
        public Task(string name)
        {
            Name = name;       
        }
    }
}