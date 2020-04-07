using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppTracker
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSent { get; set; }
        public string EmployerName { get; set; }
        public string Position { get; set; }
        public string Area { get; set; }
        public string AppStatus { get; set; }
    }
}
