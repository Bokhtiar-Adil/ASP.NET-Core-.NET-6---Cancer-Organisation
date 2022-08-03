using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Forms.BloodDonerForm
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

        [BindProperty]
      public BloodDoner BloodDoner { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BloodDonerTable == null)
            {
                return NotFound();
            }

            var blooddoner = await _context.BloodDonerTable.FirstOrDefaultAsync(m => m.BB_Id == id);

            if (blooddoner == null)
            {
                return NotFound();
            }
            else 
            {
                BloodDoner = blooddoner;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.BloodDonerTable == null)
            {
                return NotFound();
            }
            var blooddoner = await _context.BloodDonerTable.FindAsync(id);

            if (blooddoner != null)
            {
                BloodDoner = blooddoner;
                _context.BloodDonerTable.Remove(BloodDoner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
