// ===========================================================================
/// <summary>
/// Index.cshtml.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorasp_shoper.Pages
{
        public class IndexModel : PageModel
        {
                private readonly ILogger<IndexModel> _logger;

                public IndexModel(ILogger<IndexModel> logger)
                {
                        _logger = logger;
                }

                public void OnGet()
                {

                }
        }
}
