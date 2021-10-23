using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CriptQuery;

namespace NugetPackage_CriptQuery.Pages
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
            var security = new SecureQueryString();
            security["emailDoUsuario"] = "test@gmail.com";

            Response.Redirect($"Privacy?id={security}");
        }
    }
}
