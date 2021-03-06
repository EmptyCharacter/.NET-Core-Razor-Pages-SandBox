﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Application.Models;
using Newtonsoft.Json;

namespace Application
{
    public class IndexModel : PageModel
    {
        private readonly Application.Data.ApplicationContext _context;

        public IndexModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<EntryInfo> EntryInfo { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task<List<EntryInfo>> GetDataList(ApplicationContext _context)
        {
            var entryItems = await _context.EntryInfo
            .Include(b => b.City)
            .ToListAsync();
            return entryItems;
        }

        public async Task OnGetAsync()
        {
            var entry = from e in _context.EntryInfo
                        select e;
            if(!string.IsNullOrEmpty(SearchString))
            {
                entry = entry.Where(s => s.City.Contains(SearchString));
            }
            EntryInfo = await entry.ToListAsync();
            
        }

        

        

    }
}
