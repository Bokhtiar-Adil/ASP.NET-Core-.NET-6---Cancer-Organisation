using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.EventsListAdmin
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext07 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext07 context)
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

            var events =  await _context.EventsTable.FirstOrDefaultAsync(m => m.Ev_Id == id);
            if (events == null)
            {
                return NotFound();
            }
            Events = events;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Events).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventsExists(Events.Ev_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventsExists(int id)
        {
          return (_context.EventsTable?.Any(e => e.Ev_Id == id)).GetValueOrDefault();
        }
    }
}
