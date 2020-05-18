using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Application.Models
{
    public class EntryInfo
    {
        public int ID { get; set; }

        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }
        public string Position { get; set; }

        public string City { get; set; }
        public DateTime Date { get; set; }

        public string Decision { get; set; }

    }

   


}
