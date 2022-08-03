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

namespace NonProfitSiteV3.Pages.Lists.RegisteredVolunteersList
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext06 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext06 context)
        {
            _context = context;
        }

        [BindProperty]
        public VolunteerRegistered VolunteerRegistered { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RegisteredVolunteerTable == null)
            {
                return NotFound();
            }

            var volunteerregistered =  await _context.RegisteredVolunteerTable.FirstOrDefaultAsync(m => m.VReg_Id == id);
            if (volunteerregistered == null)
            {
                return NotFound();
            }
            VolunteerRegistered = volunteerregistered;
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

            _context.Attach(VolunteerRegistered).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerRegisteredExists(VolunteerRegistered.VReg_Id))
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

        private bool VolunteerRegisteredExists(int id)
        {
          return (_context.RegisteredVolunteerTable?.Any(e => e.VReg_Id == id)).GetValueOrDefault();
        }
    }
}
