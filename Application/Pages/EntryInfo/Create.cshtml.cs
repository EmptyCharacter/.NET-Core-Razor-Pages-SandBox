using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Application.Data;
using Application.Models;

namespace Application
{
    public class CreateModel : PageModel
    {
        private readonly Application.Data.ApplicationContext _context;

        public CreateModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EntryInfo EntryInfo { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EntryInfo.Add(EntryInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
