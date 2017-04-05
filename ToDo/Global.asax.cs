using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using ToDo.Api.Task.Repository;
using ToDo.Api.Task.Service;

namespace ToDo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var dbContext = new ApplicationDbContext();

            builder.RegisterInstance(dbContext).As<ApplicationDbContext>();
            builder.Register(c => new TaskRepository(dbContext)).As<ITaskRepository>();
            builder.Register(c => new TaskService(new TaskRepository(dbContext))).As<ITaskService>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
