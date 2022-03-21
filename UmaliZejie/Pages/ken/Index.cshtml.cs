#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UmaliZejie.Data;
using UmaliZejie.Models;

namespace UmaliZejie.Pages.ken
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly UmaliZejie.Data.UmaliZejieContext _context;

        public IndexModel(UmaliZejie.Data.UmaliZejieContext context)
        {
            _context = context;
        }

        public IList<Shops> Shops { get;set; }

        public async Task OnGetAsync()
        {
            Shops = await _context.Shops.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
