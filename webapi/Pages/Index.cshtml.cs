// ===========================================================================
/// <summary>
/// Index.cshtml.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapi.Pages
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