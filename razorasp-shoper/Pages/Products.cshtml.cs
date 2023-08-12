// ===========================================================================
/// <summary>
/// Products.cshtml.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 10.08.2023
/// </summary>
/// <created>ʆϒʅ, 10.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razorasp_shoper.Data;
using razorasp_shoper.Models;

namespace razorasp_shoper.Pages
{
    public class ProductsModel: PageModel
    {

        private readonly shoperContext _context;
        private readonly ILogger<ProductsModel> _logger;

        public ProductsModel(shoperContext context, ILogger<ProductsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Product> filteredProducts { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string searchField { get; set; } = string.Empty;
        public SelectList categoryList { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        //public Categories categoryField { get; set; }
        public Categories? categoryField { get; set; } = Categories.Categories;

        public async Task OnGetAsync()
        {

            if (_context.Products != null)
            {
                var productsQuery = from entities in _context.Products select entities;
                var categoriesQuery = from entities in _context.Products
                                      orderby entities.Category
                                      select entities.Category;
                if (!String.IsNullOrEmpty(searchField))
                {
                    productsQuery = productsQuery.Where(item => item.Name.Contains(searchField));
                }
                if (!categoryField.Equals(Categories.Categories))
                {
                    productsQuery = productsQuery.Where(item => item.Category.Equals(categoryField));
                }

                filteredProducts = await productsQuery.ToListAsync();
                categoryList = new SelectList(await categoriesQuery.Distinct().ToListAsync());

            }
        }
    }
}
