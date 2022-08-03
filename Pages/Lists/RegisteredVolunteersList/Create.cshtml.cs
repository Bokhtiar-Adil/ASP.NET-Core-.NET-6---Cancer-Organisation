using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.RegisteredVolunteersList
{
    public class CreateModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext06 _context;

        public CreateModel(NonProfitSiteV3.Data.AppDbContext06 context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VolunteerRegistered VolunteerRegistered { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.RegisteredVolunteerTable == null || VolunteerRegistered == null)
            {
                return Page();
            }

            _context.RegisteredVolunteerTable.Add(VolunteerRegistered);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
