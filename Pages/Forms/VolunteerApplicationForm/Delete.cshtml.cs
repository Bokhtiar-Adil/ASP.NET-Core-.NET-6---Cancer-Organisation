using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Forms.VolunteerApplicationForm
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext05 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext05 context)
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

            var volunteerapplicants = await _context.VolAppTable.FirstOrDefaultAsync(m => m.VA_Id == id);

            if (volunteerapplicants == null)
            {
                return NotFound();
            }
            else 
            {
                VolunteerApplicants = volunteerapplicants;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VolAppTable == null)
            {
                return NotFound();
            }
            var volunteerapplicants = await _context.VolAppTable.FindAsync(id);

            if (volunteerapplicants != null)
            {
                VolunteerApplicants = volunteerapplicants;
                _context.VolAppTable.Remove(VolunteerApplicants);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
