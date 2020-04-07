using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class AppTracker
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Sent")]
        public DateTime DateSent { get; set; }
        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }
        public string Position { get; set; }
        public string Area { get; set; }
        [Display(Name = "Application Status")]
        public string AppStatus { get; set; }
    }
}
