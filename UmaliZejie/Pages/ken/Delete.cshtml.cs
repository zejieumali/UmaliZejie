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
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly UmaliZejie.Data.UmaliZejieContext _context;

        public DeleteModel(UmaliZejie.Data.UmaliZejieContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Shops = await _context.Shops.FindAsync(id);

            if (Shops != null)
            {
                _context.Shops.Remove(Shops);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
}
