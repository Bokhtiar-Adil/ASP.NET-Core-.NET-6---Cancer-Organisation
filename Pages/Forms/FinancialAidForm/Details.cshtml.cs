using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Forms.FinancialAidForm
{
    public class DetailsModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public DetailsModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

      public FinancialAid FinancialAid { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FinancialAidTable == null)
            {
                return NotFound();
            }

            var financialaid = await _context.FinancialAidTable.FirstOrDefaultAsync(m => m.AID_Id == id);
            if (financialaid == null)
            {
                return NotFound();
            }
            else 
            {
                FinancialAid = financialaid;
            }
            return Page();
        }
    }
}
