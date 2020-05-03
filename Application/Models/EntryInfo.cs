using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Services;

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

    [WebMethod]
    public static List<ChartDetails> GetChartData()
    {
        List<ChartDetails> dataList = new List<ChartDetails>();

        // Access SQL Database Data
        // Assign SQL Data to List<ChartDetails> dataList

        return dataList;
    }


}
