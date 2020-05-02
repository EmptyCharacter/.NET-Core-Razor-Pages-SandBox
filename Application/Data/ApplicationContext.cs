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
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        

        public DbSet<Application.Models.EntryInfo> EntryInfo { get; set; }

       
        public async List<EntryInfo> GetCityList()
        {
            var cityItems = await _context.EntryInfo
                .Where(b => b.Enabled)
                .OrderBy(b => b.City)
                .Select(b => new SelectListItem
                {
                Value = b.Id,
                Text = b.CIty
                })
                .ToListAsync();
        }
    }


}
