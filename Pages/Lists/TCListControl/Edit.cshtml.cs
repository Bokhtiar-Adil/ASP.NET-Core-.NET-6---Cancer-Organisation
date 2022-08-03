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

namespace NonProfitSiteV3.Pages.Lists.TCListControl
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext03 context)
        {
            _context = context;
        }

        [BindProperty]
        public TreatmentCenters TreatmentCenters { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TreatmentCentersList2 == null)
            {
                return NotFound();
            }

            var treatmentcenters =  await _context.TreatmentCentersList2.FirstOrDefaultAsync(m => m.TC_Id == id);
            if (treatmentcenters == null)
            {
                return NotFound();
            }
            TreatmentCenters = treatmentcenters;
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

            _context.Attach(TreatmentCenters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreatmentCentersExists(TreatmentCenters.TC_Id))
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

        private bool TreatmentCentersExists(int id)
        {
          return (_context.TreatmentCentersList2?.Any(e => e.TC_Id == id)).GetValueOrDefault();
        }
    }
}
