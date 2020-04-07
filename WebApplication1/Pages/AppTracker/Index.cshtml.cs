using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public IndexModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<AppTracker> AppTracker { get;set; }
        public string SearchString { get; set; }
        

        public async Task OnGetAsync()
        {
            var area = from m in _context.AppTracker
                         select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                area = area.Where(s => s.Area.Contains(SearchString));
            }

            AppTracker = await area.ToListAsync();
        }
    }
}
