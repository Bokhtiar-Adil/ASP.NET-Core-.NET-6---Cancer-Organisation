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

namespace NonProfitSiteV3.Pages.Lists.DoctorsListControl
{
    public class EditModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public EditModel(NonProfitSiteV3.Data.AppDbContext03 context)
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

            var doctors =  await _context.DoctorsList2.FirstOrDefaultAsync(m => m.Doc_Id == id);
            if (doctors == null)
            {
                return NotFound();
            }
            Doctors = doctors;
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

            _context.Attach(Doctors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorsExists(Doctors.Doc_Id))
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

        private bool DoctorsExists(int id)
        {
          return (_context.DoctorsList2?.Any(e => e.Doc_Id == id)).GetValueOrDefault();
        }
    }
}
