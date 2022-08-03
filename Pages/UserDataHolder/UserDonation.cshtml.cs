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
    public class UserDonationModel : PageModel
    {
        private readonly NonProfitSiteV3.Data.AppDbContext04 _context;

        public UserDonationModel(NonProfitSiteV3.Data.AppDbContext04 context)
        {
            _context = context;
        }

        public IList<Donation> Donation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DonationTable != null)
            {
                Donation = await _context.DonationTable.ToListAsync();
            }
        }
    }
}
