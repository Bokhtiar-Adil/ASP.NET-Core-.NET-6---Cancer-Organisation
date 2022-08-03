using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.RegisteredVolunteersList
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext06 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext06 context)
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

            var volunteerregistered = await _context.RegisteredVolunteerTable.FirstOrDefaultAsync(m => m.VReg_Id == id);

            if (volunteerregistered == null)
            {
                return NotFound();
            }
            else 
            {
                VolunteerRegistered = volunteerregistered;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.RegisteredVolunteerTable == null)
            {
                return NotFound();
            }
            var volunteerregistered = await _context.RegisteredVolunteerTable.FindAsync(id);

            if (volunteerregistered != null)
            {
                VolunteerRegistered = volunteerregistered;
                _context.RegisteredVolunteerTable.Remove(VolunteerRegistered);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
