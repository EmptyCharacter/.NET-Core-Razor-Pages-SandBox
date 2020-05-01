using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Application.Models
{
  
    public List<EntryInfo> getData()
    {
        var entryItems = await _context.EntryInfo
            .Where(b => b.Enabled)
            .OrderBy(b => b.Name)
            .Select(b => new SelectListItem){
                Value = bool.Id, Text = b.Name})
        .ToListAsync();
    }





}
