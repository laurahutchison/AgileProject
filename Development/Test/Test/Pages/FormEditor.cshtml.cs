using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Pages
{
    public class FormEditorModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public String title { get; set; }

        public void OnGet()
        {
            
        }
    }
}
