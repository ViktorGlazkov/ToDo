using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDo.Models;

namespace ToDo.Controllers
{
    [Authorize]
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("tasks"), HttpGet]
        public IEnumerable<Task> Get()
        {
            var values = new List<Task>();
            values.Add(new Task("value1"));
            values.Add(new Task("value2"));
            values.Add(new Task("value3"));

            return values;
        }    
    }
}
