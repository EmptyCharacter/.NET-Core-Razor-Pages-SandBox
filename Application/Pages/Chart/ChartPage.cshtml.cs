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

        public Array ChartOne()
        {
            int[] MonthCount = new int[12];
            //Data access


            //loop through all rows in date column and compare i with matching date value
            int counter = 0;
            for(int i = 0; i < 12; i++)
            {
                //if matching value then increase counter
            }

            return MonthCount;
        }
    }
}