using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages
{
    public class NewsEventsModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext07 _context;

        public NewsEventsModel(NonProfitSiteV3.Data.AppDbContext07 context)
        {
            _context = context;
        }

        public IList<Events> Events { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.EventsTable != null)
            {
                Events = await _context.EventsTable.ToListAsync();
            }
        }
    }
}
