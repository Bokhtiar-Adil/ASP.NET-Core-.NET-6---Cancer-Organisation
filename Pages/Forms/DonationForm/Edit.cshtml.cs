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

namespace NonProfitSiteV3.Pages.Forms.DonationForm
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext04 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext04 context)
        {
            _context = context;
        }

        [BindProperty]
        public Donation Donation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DonationTable == null)
            {
                return NotFound();
            }

            var donation =  await _context.DonationTable.FirstOrDefaultAsync(m => m.Don_ID == id);
            if (donation == null)
            {
                return NotFound();
            }
            Donation = donation;
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

            _context.Attach(Donation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationExists(Donation.Don_ID))
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

        private bool DonationExists(int id)
        {
          return (_context.DonationTable?.Any(e => e.Don_ID == id)).GetValueOrDefault();
        }
    }
}
