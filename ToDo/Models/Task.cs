using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Value
    {
        public string Name { get; set; }

        public Value(string name)
        {
            Name = name;
        }
    }
}