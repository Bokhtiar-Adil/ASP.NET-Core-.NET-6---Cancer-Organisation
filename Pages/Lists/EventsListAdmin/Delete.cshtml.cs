using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.EventsListAdmin
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext07 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext07 context)
        {
            _context = context;
        }

        [BindProperty]
      public Events Events { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.EventsTable == null)
            {
                return NotFound();
            }

            var events = await _context.EventsTable.FirstOrDefaultAsync(m => m.Ev_Id == id);

            if (events == null)
            {
                return NotFound();
            }
            else 
            {
                Events = events;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.EventsTable == null)
            {
                return NotFound();
            }
            var events = await _context.EventsTable.FindAsync(id);

            if (events != null)
            {
                Events = events;
                _context.EventsTable.Remove(Events);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
