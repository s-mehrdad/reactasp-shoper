// ===========================================================================
/// <summary>
/// Create.cshtml.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 03.08.2023
/// </summary>
/// <created>ʆϒʅ, 03.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razorasp_shoper.Data;
using razorasp_shoper.Models;

namespace razorasp_shoper.Pages.Carts
{
    public class CreateModel : PageModel
    {
        private readonly shoperContext _context;

        public CreateModel(shoperContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cart Cart { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //var a = new ICollection<Purchase>{ 1}
            //Cart.Purchases.Add(_context.Purchases.Find(1).);
            if (!this.ModelState.IsValid || _context.Carts == null || Cart == null)
            {
                return Page();
            }

            _context.Carts.Add(Cart);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
