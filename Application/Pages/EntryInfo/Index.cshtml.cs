using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Application.Models;

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
