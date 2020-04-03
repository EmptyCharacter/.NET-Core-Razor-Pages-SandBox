using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core_Sandbox.Models;

namespace Core_Sandbox.Data
{
    public class Core_SandboxContext : DbContext
    {
        public Core_SandboxContext (DbContextOptions<Core_SandboxContext> options)
            : base(options)
        {
        }

        public DbSet<Core_Sandbox.Models.Student> Student { get; set; }
    }
}
