using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTracker.Models
{
    public class Application
    {
        [DataType(DataType.)]
        public DateTime DateSent { get; set; }
        public string EmployerName { get; set; }
        public string Position { get; set; }

        public string Area { get; set; }
        public string AppStatus { get; set; }
    }
}
