using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Application
{
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        public EntryInfo[] EntryInfoArray { get; set; }
        public DateTime[] DateArray;

        public async Task OnGetAsync()
        {
           
        }


        
        public Array ChartOne()
        {
            DateTime[] DateArray = EntryInfoArray.Select(x => x.Date).ToArray();
            sortArray(DateArray);
            return DateArray;
        }


        public Array sortArray(Array test)
        {
            
        }


    }
}