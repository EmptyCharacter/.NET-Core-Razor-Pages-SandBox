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

        private readonly Application.Data.ApplicationContext _context;
        public CreateModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        

        public DbSet<Application.Models.EntryInfo> EntryInfo { get; set; }

        public DbSet<ApplicationContext> CatalogItems { get; set; }

        public DbSet<ApplicationContext> CatalogBrands { get; set; }

        public DbSet<ApplicationContext> CatalogTypes { get; set; }

        public async Task<List<EntryInfo>> GetCityList()
        {
            var cityItems = await _context.CatalogItems
                .Where(b => b.Enabled)
                .OrderBy(b => b.City)
                .Select(b => new SelectListItem
                {
                Value = b.Id,
                Text = b.CIty
                })
                .ToListAsync();
            return cityItems;
        }
    }


}
