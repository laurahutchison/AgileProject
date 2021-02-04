using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;

namespace Test.Pages
{
    public class QuestionnaireListModel : PageModel
    {

        private DatabaseContext db;
        [BindProperty]
        public List<questionnaires> QuestionnairesLists { get; set; }


        public QuestionnaireListModel(DatabaseContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            QuestionnairesLists = db.QuestionnairesHandler.ToList();

        }

        public IActionResult OnPostExport()
        {

            Console.WriteLine("1234567");
            return RedirectToPage("./Index");

        }

        public IActionResult OnPost() {

            Console.WriteLine("1234567");
            return RedirectToPage("./Index");
        }



    }
}
