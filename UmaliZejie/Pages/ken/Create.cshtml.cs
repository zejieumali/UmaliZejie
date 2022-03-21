#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UmaliZejie.Data;
using UmaliZejie.Models;

namespace UmaliZejie.Pages.ken
{
    public class CreateModel : PageModel
    {
        private readonly UmaliZejie.Data.UmaliZejieContext _context;

        public CreateModel(UmaliZejie.Data.UmaliZejieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shops Shops { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shops.Add(Shops);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
