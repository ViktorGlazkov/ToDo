namespace ToDo
{
    using Api.Task;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {      
        public ApplicationDbContext() : base("ToDoDbContext") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}