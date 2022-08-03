using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.RegisteredVolunteersList
{
    public class IndexModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext06 _context;

        public IndexModel(NonProfitSiteV3.Data.AppDbContext06 context)
        {
            _context = context;
        }

        public IList<VolunteerRegistered> VolunteerRegistered { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RegisteredVolunteerTable != null)
            {
                VolunteerRegistered = await _context.RegisteredVolunteerTable.ToListAsync();
            }
        }
    }
}
