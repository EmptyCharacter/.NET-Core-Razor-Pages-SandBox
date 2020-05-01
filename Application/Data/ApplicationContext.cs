using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Models;

namespace Application.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Application.Models.EntryInfo> EntryInfo { get; set; }

        public DbSet<ApplicationPositions> ApplicationPositions { get; set; }
        public DbSet<ApplicationCities> ApplicationCities { get; set; }
        public DbSet<ApplicationEmployerNames> ApplicationEmployerNames { get; set; }
    }


}
