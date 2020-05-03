using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Application.Data
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }




        public DbSet<Application.Models.EntryInfo> EntryInfo { get; set; }

        public async Task<List<EntryInfo>> GetDataList()
        {
            var entryItems = await _context.EntryInfo
            .Where(b => b.Enabled)
            .OrderBy(b => b.Name)
            .Select(b => new SelectListItem
            {
                Value = b.Id,
                Text = b.City
            })
            .ToListAsync();
            return entryItems;
        }


    }
}