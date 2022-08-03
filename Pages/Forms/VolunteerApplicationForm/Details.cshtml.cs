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
    public class DetailsModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext05 _context;

        public DetailsModel(NonProfitSiteV3.Data.AppDbContext05 context)
        {
            _context = context;
        }

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
    }
}
