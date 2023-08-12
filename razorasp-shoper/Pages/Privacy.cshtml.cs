// ===========================================================================
/// <summary>
/// Privacy.cshtml.cs
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
        public class PrivacyModel : PageModel
        {
                private readonly ILogger<PrivacyModel> _logger;

                public PrivacyModel(ILogger<PrivacyModel> logger)
                {
                        _logger = logger;
                }

                public void OnGet()
                {
                }
        }
}
