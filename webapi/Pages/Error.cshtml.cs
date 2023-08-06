// ===========================================================================
/// <summary>
/// Error.cshtml.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace webapi.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel: PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}