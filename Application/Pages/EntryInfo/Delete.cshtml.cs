﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Application.Data.ApplicationContext _context;

        public DeleteModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EntryInfo EntryInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EntryInfo = await _context.EntryInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (EntryInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EntryInfo = await _context.EntryInfo.FindAsync(id);

            if (EntryInfo != null)
            {
                _context.EntryInfo.Remove(EntryInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
