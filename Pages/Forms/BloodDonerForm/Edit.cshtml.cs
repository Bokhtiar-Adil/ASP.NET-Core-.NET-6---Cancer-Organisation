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

namespace NonProfitSiteV3.Pages.Forms.BloodDonerForm
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext01 context)
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

            var blooddoner =  await _context.BloodDonerTable.FirstOrDefaultAsync(m => m.BB_Id == id);
            if (blooddoner == null)
            {
                return NotFound();
            }
            BloodDoner = blooddoner;
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

            _context.Attach(BloodDoner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodDonerExists(BloodDoner.BB_Id))
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

        private bool BloodDonerExists(int id)
        {
          return (_context.BloodDonerTable?.Any(e => e.BB_Id == id)).GetValueOrDefault();
        }
    }
}
