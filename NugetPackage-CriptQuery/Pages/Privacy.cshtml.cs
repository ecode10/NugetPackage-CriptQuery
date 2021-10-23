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
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(Request.Query["id"]))
                Response.Redirect("index");

            var _id = Request.Query["id"];

            var security = new SecureQueryString(_id);
            var email = security["emailDoUsuario"];

            Console.Write(email);
        }
    }
}
