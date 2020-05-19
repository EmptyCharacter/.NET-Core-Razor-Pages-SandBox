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

        public EntryInfo EntryInfo { get; set; }

        public async Task OnGetAsync()
        {
           
        }


        
        public Array ChartOne()
        {

            using (Var db = new EntryInfo())
            {
                Var studentes = db.Students.Where(s => s.FirstName == "MyName").ToList();
            }
        }


        public Array sortArray(Array test)
        {
            int[] newArray =  new int[12];
            return newArray;
        }


    }
}