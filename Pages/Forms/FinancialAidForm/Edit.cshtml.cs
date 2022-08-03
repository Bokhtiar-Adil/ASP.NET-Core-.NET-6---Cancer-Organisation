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

namespace NonProfitSiteV3.Pages.Forms.FinancialAidForm
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

        [BindProperty]
        public FinancialAid FinancialAid { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FinancialAidTable == null)
            {
                return NotFound();
            }

            var financialaid =  await _context.FinancialAidTable.FirstOrDefaultAsync(m => m.AID_Id == id);
            if (financialaid == null)
            {
                return NotFound();
            }
            FinancialAid = financialaid;
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

            _context.Attach(FinancialAid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinancialAidExists(FinancialAid.AID_Id))
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

        private bool FinancialAidExists(int id)
        {
          return (_context.FinancialAidTable?.Any(e => e.AID_Id == id)).GetValueOrDefault();
        }
    }
}
