using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core_Sandbox.Data;
using Core_Sandbox.Models;

namespace Core_Sandbox
{
    public class IndexModel : PageModel
    {
        private readonly Core_Sandbox.Data.Core_SandboxContext _context;

        public IndexModel(Core_Sandbox.Data.Core_SandboxContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
