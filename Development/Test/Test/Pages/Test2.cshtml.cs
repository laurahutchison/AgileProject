using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;

namespace Test.Pages
{
    public class Test2Model : PageModel
    {
        private DatabaseContext db;

        [BindProperty]
        public questionanswerexample test { get; set; }

        public Test2Model(DatabaseContext _db)
        {
            db = _db;
        }

        public List<questionanswerexample> TestTables { get; set; }
        public void OnGet()
        {
            TestTables = db.TestTables.ToList();
            Console.Write("hjkl");
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid == false)
            {
                return Page();
            }

            if (test.Equals(null))
            {
                return RedirectToPage("./Index");
            }

            //replace with any other variables needing sorted thru/etc
            bool ifExists = db.TestTables.Any(questionanswerexample => questionanswerexample.questionAnswerID == test.questionAnswerID);

            if (ifExists)
            {
                //remove entry
                db.Remove(db.TestTables.Find(test.questionAnswerID));
                db.SaveChanges();
            }
            else if (!ifExists)
            {
                //replace with some prompt on the screen - bool that when returns false, a prompt pops up on screen?
                Console.WriteLine("Not existing!");

            }



            return RedirectToPage("./Index");



        }
    }
}
