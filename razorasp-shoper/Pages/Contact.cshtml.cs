// ===========================================================================
/// <summary>
/// Contact.cshtml.cs
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
        public class ContactModel : PageModel
        {
                private readonly ILogger<ContactModel> _logger;

                public ContactModel(ILogger<ContactModel> logger)
                {
                        _logger = logger;
                }
                public void OnGet()
                {
                }
        }
}
