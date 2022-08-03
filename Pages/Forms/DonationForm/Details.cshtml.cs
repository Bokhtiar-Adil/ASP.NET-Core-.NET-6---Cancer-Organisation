using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Forms.DonationForm
{
    public class DetailsModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext04 _context;

        public DetailsModel(NonProfitSiteV3.Data.AppDbContext04 context)
        {
            _context = context;
        }

      public Donation Donation { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DonationTable == null)
            {
                return NotFound();
            }

            var donation = await _context.DonationTable.FirstOrDefaultAsync(m => m.Don_ID == id);
            if (donation == null)
            {
                return NotFound();
            }
            else 
            {
                Donation = donation;
            }
            return Page();
        }
    }
}
