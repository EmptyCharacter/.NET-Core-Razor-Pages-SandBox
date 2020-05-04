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
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                TextBox1.Text = row["ImagePath"].ToString();
            }
        }
    }
}