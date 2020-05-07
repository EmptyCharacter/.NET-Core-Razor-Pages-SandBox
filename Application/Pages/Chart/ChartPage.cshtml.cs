using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class ChartPageModel : PageModel
    {
        private readonly Application.Data.ApplicationContext _context;

        public ChartPageModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<EntryInfo> EntryInfo { get; set; }

        public async Task OnGetAsync()
        {
           
        }

        //The array must have a max size of 12 due to the restraints given from the data 
        //structure of the bar chart
        //Labels will be months of the year
        //datapoints will be amt sent during that month
        
        //no clue
    }
}