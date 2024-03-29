﻿// ===========================================================================
/// <summary>
/// Index.cshtml.cs
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
using Microsoft.EntityFrameworkCore;
using razorasp_shoper.Data;
using razorasp_shoper.Models;

namespace razorasp_shoper.Pages.Carts
{
    public class IndexModel : PageModel
    {
        private readonly shoperContext _context;

        public IndexModel(shoperContext context)
        {
            _context = context;
        }

        public IList<Cart> Cart { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Carts != null)
            {
                Cart = await _context.Carts.ToListAsync();
            }
        }
    }
}
