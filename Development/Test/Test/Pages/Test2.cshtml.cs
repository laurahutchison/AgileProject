using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;
using Newtonsoft.Json.Linq;


namespace Test.Pages

{
    public class Test2Model : PageModel
    {
        private DatabaseContext db;
        private string sPath;
        //private DatabaseContext db2;

        [BindProperty]
        public questionanswerexample test { get; set; }

        public jsonstore test2;


        public Test2Model(DatabaseContext _db)
        {
            db = _db;
        }

        public List<questionanswerexample> TestTables { get; set; }
        public void OnGet()
        {
            TestTables = db.TestTables.ToList();
            sPath = Environment.CurrentDirectory.ToString();

            JObject o1 = JObject.Parse(System.IO.File.ReadAllText(sPath + @"\appsettings.json"));

            test2 = new jsonstore(0, o1.ToString(Newtonsoft.Json.Formatting.None));


            db.JsonHandler.Add(test2);
            db.SaveChanges();

            //test2.jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(o1);
            //sPath = System.IO.Directory.GetParent(str_directory).FullName;

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

            else if (test.questionAnswerID == null)
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



          

            Console.WriteLine("test");
            //db.Example.Add(test2);
           // db.SaveChanges();





            return RedirectToPage("./Index");



        }
    }
}
