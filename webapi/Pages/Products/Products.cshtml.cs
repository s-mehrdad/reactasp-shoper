// ===========================================================================
/// <summary>
/// Products.cshtml.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 09.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapi_shoper.Data;
using webapi_shoper.Models;

namespace webapi.Pages.Products
{
    public class ProductsModel: PageModel
    {
        // private readonly shoperSQLEContext _context;
        // public ProductsModel(shoperSQLEContext context)
        // {
        //     _context = context;
        // }

        private readonly ILogger<ProductsModel> _logger;

        public ProductsModel(ILogger<ProductsModel> logger)
        {
            _logger = logger;
        }


        public string aProduct { get; set; } = default!;
        public void OnGet()
        {
            // aProduct = _context.Products.First<Product>().Name;
        }
    }
}
