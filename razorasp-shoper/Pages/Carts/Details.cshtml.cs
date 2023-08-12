// ===========================================================================
/// <summary>
/// Details.cshtml.cs
/// mvcasp-shoper
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
using Microsoft.EntityFrameworkCore;
using razorasp_shoper.Data;
using razorasp_shoper.Models;

namespace razorasp_shoper.Pages.Carts
{
    public class DetailsModel : PageModel
    {
        private readonly shoperContext _context;

        public DetailsModel(shoperContext context)
        {
            _context = context;
        }

        public Cart Cart { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Carts == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }
            else
            {
                Cart = cart;
            }
            return Page();
        }
    }
}
