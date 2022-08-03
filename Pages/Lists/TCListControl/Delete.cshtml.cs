using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.TCListControl
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext03 context)
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

            var treatmentcenters = await _context.TreatmentCentersList2.FirstOrDefaultAsync(m => m.TC_Id == id);

            if (treatmentcenters == null)
            {
                return NotFound();
            }
            else 
            {
                TreatmentCenters = treatmentcenters;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TreatmentCentersList2 == null)
            {
                return NotFound();
            }
            var treatmentcenters = await _context.TreatmentCentersList2.FindAsync(id);

            if (treatmentcenters != null)
            {
                TreatmentCenters = treatmentcenters;
                _context.TreatmentCentersList2.Remove(TreatmentCenters);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
