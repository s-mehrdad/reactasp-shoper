// ===========================================================================
/// <summary>
/// Products.cshtml.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapi_shoper.Data;

namespace webapi.Pages.Products
{
    public class ProductsModel: PageModel
    {
        private readonly ILogger<ProductsModel> _logger;

        public ProductsModel(ILogger<ProductsModel> logger)
        {
            _logger = logger;
        }

        //private readonly _context;

        public void OnGet()
        {
        }
    }
}
