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
    public class DetailsModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public DetailsModel(NonProfitSiteV3.Data.AppDbContext03 context)
        {
            _context = context;
        }

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
    }
}
