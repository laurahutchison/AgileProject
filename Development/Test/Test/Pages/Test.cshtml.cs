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
    }
}
