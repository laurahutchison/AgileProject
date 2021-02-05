using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;

namespace Test.Pages
{
    public class TestModel : PageModel
    {
        private DatabaseContext db;
        
        [BindProperty]
        public questionanswerexample test { get; set; }

        public TestModel(DatabaseContext _db)
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

            if(ifExists){
                //update data
                db.Entry(test).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            else if(!ifExists){
                //if (db.TestTables.Contains<questionanswerexample>(test.questionAnswerID))
                //Add to database - add to the dbSet in Database Context, then save changes
                db.TestTables.Add(test);
                db.SaveChanges();

            }



            return RedirectToPage("./Index");



        }
    }
}
