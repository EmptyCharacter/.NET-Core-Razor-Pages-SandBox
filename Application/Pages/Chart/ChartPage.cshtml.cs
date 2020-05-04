using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

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
            var results = from myRow in myDataTable.AsEnumerable()
            where myRow.Field<int>("RowNo") == 1
            select myRow;
        }
        public async Task<List<EntryInfo>> GetDataList(ApplicationContext _context)
        {
            var entryItems = await _context.EntryInfo
            .Include(b => b.City)
            .ToListAsync();
            return entryItems;
        }

    }
}