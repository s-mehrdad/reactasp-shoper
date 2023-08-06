// ===========================================================================
/// <summary>
/// Privacy.cshtml.cs
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