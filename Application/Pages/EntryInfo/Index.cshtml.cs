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

        public async Task OnGetAsync()
        {
            EntryInfo = await _context.EntryInfo.ToListAsync();
        }
    }
}
