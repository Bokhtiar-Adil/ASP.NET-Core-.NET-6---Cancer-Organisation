using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.Lists.TCListControl
{
    public class IndexModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext03 _context;

        public IndexModel(NonProfitSiteV3.Data.AppDbContext03 context)
        {
            _context = context;
        }

        public IList<TreatmentCenters> TreatmentCenters { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TreatmentCentersList2 != null)
            {
                TreatmentCenters = await _context.TreatmentCentersList2.ToListAsync();
            }
        }
    }
}
