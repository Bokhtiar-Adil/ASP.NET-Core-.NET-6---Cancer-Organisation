using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages
{
    public class VolunteerReqFormModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public VolunteerReqFormModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VolunteerRequest VolunteerRequest { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.VolunteerReqTable == null || VolunteerRequest == null)
            {
                return Page();
            }

            _context.VolunteerReqTable.Add(VolunteerRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
