using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Forms.VolunteerRequestForm
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

        [BindProperty]
      public VolunteerRequest VolunteerRequest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VolunteerReqTable == null)
            {
                return NotFound();
            }

            var volunteerrequest = await _context.VolunteerReqTable.FirstOrDefaultAsync(m => m.VLreq_Id == id);

            if (volunteerrequest == null)
            {
                return NotFound();
            }
            else 
            {
                VolunteerRequest = volunteerrequest;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VolunteerReqTable == null)
            {
                return NotFound();
            }
            var volunteerrequest = await _context.VolunteerReqTable.FindAsync(id);

            if (volunteerrequest != null)
            {
                VolunteerRequest = volunteerrequest;
                _context.VolunteerReqTable.Remove(VolunteerRequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
