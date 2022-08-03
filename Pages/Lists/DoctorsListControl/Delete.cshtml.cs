using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.DoctorsListControl
{
    public class DeleteModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public DeleteModel(NonProfitSiteV3.Data.AppDbContext03 context)
        {
            _context = context;
        }

        [BindProperty]
      public Doctors Doctors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DoctorsList2 == null)
            {
                return NotFound();
            }

            var doctors = await _context.DoctorsList2.FirstOrDefaultAsync(m => m.Doc_Id == id);

            if (doctors == null)
            {
                return NotFound();
            }
            else 
            {
                Doctors = doctors;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DoctorsList2 == null)
            {
                return NotFound();
            }
            var doctors = await _context.DoctorsList2.FindAsync(id);

            if (doctors != null)
            {
                Doctors = doctors;
                _context.DoctorsList2.Remove(Doctors);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
