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
    public class DetailsModel : PageModel
    {
        private readonly UmaliZejie.Data.UmaliZejieContext _context;

        public DetailsModel(UmaliZejie.Data.UmaliZejieContext context)
        {
            _context = context;
        }

        public Shops Shops { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shops = await _context.Shops.FirstOrDefaultAsync(m => m.ID == id);

            if (Shops == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
