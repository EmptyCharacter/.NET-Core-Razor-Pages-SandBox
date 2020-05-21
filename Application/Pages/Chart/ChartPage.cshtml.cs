using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Application.Data;

using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Application
{
    [Serializable]
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }

        
        public EntryInfo EntryInfo { get; set; }
        public List<DateTime> EntryInfoArray { get; set; }
        public List<DateTime> DateList;


        public void OnGet()
        {

        }


        //-------------------------------First Chart-------------------------------------
        
        public Action SOmething()
        {
            
        }
    
        public int[] ChartOne()
        {
            //Logic is there but now you need to populate List from the database
            List<DateTime> DateList = _context.EntryInfo.Select(x => x.Date).ToList();
            List<int> temp = SortArray(DateList);
            return temp.ToArray();
        }

        




        public List<int> SortArray(List<DateTime> test)
        {
            List<int> tempList = new List<int>();
            for (var i = 1; i <= 12; i++)
            {
                int counter = 0;
                foreach (DateTime d in test)
                {
                    if (d.Month == i)
                    {
                        counter++;

                    }
                }
                tempList.Add(counter);

            }
            return tempList;
        }

        //-------------------------------Second Chart-------------------------------------




    }
}