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

namespace NonProfitSiteV3.Pages.Forms.VolunteerRequestForm
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext01 context)
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

            var volunteerrequest =  await _context.VolunteerReqTable.FirstOrDefaultAsync(m => m.VLreq_Id == id);
            if (volunteerrequest == null)
            {
                return NotFound();
            }
            VolunteerRequest = volunteerrequest;
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

            _context.Attach(VolunteerRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerRequestExists(VolunteerRequest.VLreq_Id))
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

        private bool VolunteerRequestExists(int id)
        {
          return (_context.VolunteerReqTable?.Any(e => e.VLreq_Id == id)).GetValueOrDefault();
        }
    }
}
