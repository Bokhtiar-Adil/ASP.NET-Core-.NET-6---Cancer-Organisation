using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Data;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Pages.UserDataHolder
{
    public class UserVolunteerAidRequestModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext01 _context;

        public UserVolunteerAidRequestModel(NonProfitSiteV3.Data.AppDbContext01 context)
        {
            _context = context;
        }

        public IList<VolunteerRequest> VolunteerRequest { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VolunteerReqTable != null)
            {
                VolunteerRequest = await _context.VolunteerReqTable.ToListAsync();
            }
        }
    }
}
