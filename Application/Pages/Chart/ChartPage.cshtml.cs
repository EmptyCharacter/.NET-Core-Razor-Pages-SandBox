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

        public List<DateTime> EntryInfoArray { get; set; }
        public List<DateTime> DateArray;

        public async Task OnGetAsync()
        {
           
        }


        
        public List<DateTime> ChartOne()
        {
            List<DateTime> DateList = EntryInfoArray.Select(x => x.Date).ToList();
            List<DateTime> temp = SortArray(DateList);
            return temp;
        }


        public List<DateTime> SortArray(List<DateTime> test)
        {
            List<DateTime> tempList;
            for(var i = 0; i < test.Count; i++)
            {
                int counter = 0;
                if(test[i].Month == i)
                {
                    counter++;
                }
            }
            return tempList;
        }


    }
}