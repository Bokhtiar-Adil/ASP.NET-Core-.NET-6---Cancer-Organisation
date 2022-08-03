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

namespace NonProfitSiteV3.Pages.Forms.VolunteerApplicationForm
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext05 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext05 context)
        {
            _context = context;
        }

        [BindProperty]
        public VolunteerApplicants VolunteerApplicants { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VolAppTable == null)
            {
                return NotFound();
            }

            var volunteerapplicants =  await _context.VolAppTable.FirstOrDefaultAsync(m => m.VA_Id == id);
            if (volunteerapplicants == null)
            {
                return NotFound();
            }
            VolunteerApplicants = volunteerapplicants;
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

            _context.Attach(VolunteerApplicants).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerApplicantsExists(VolunteerApplicants.VA_Id))
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

        private bool VolunteerApplicantsExists(int id)
        {
          return (_context.VolAppTable?.Any(e => e.VA_Id == id)).GetValueOrDefault();
        }
    }
}
