using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Application.Models;
using Application.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Application
{
    
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }

        
        
        public List<DateTime> DateList;
        public List<int> final;




        //-------------------------------First Chart (Bar)-------------------------------------

        



        public List<EntryInfo> GetDataList(ApplicationContext _context)
        {
            var entryItems = _context.EntryInfo
            .Include(b => b.City)
            .ToList();
            return entryItems;
        }

        public List<int> ChartOne()
        {
            List<EntryInfo> entries = GetDataList(_context);
            List<DateTime> DateList = entries.Select(x => x.Date).ToList();
            final = SortArray(DateList);
            return final;
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

        //-------------------------------Second Chart (Line)-------------------------------------

        

        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------

        

    }
}