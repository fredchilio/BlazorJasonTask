using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJasonTask.Entidades
{
    public class Tasks
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public bool Concluded { get; set; }
        public DateTime DateCriateded { get; set; }
    }
}
