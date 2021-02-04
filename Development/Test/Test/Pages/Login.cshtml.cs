using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;
using System.Security.Cryptography;

namespace Test
{

    public class LoginModel : PageModel
    {
        private DatabaseContext db;

        [BindProperty]
        public logininfo log { get; set; }

        public LoginModel(DatabaseContext _db)
        {
            db = _db;
        }

        public List<logininfo> Login { get; set; }


        public void OnGet()
        {
            Console.Write("hjkl");

        }

        public IActionResult OnPostLogin()
        {

            Login = db.Login.ToList();

            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //true if username and password are correct
            Boolean auth = false;

            //replace with any other variables needing sorted thru/etc
            bool ifExists = db.Login.Any(Login => Login.username == log.username);
            int index = Login.FindIndex(a => a.username == log.username);


            //log = findAccount(index);

            Console.WriteLine("testing");

            //if (log.Equals(null))
            //{
            //    return RedirectToPage("./Index");
            //}

            Console.Write("fuck disssssss");

            if (ifExists)
            {
                if (findAccount(index).passwordHash == log.passwordHash)
                {
                    Console.WriteLine("dfghjkl;");
                    auth = true;
                    //return to logged in page
                    return RedirectToPage("./IndexLogIn");
                }
            }

            ViewData["auth"] = $"{auth}";

            // here we return to not logged in page
            return RedirectToPage("./Index");
        }

        public IActionResult OnPostCreate()
        {


            if (ModelState.IsValid == false)
            {
                return Page();
            }

            Login = db.Login.ToList();

            bool ifExists = db.Login.Any(Login => Login.username == log.username);
            int index = Login.FindIndex(a => a.username == log.username);

            if (ifExists)
            {
                //code here account already exists
                Console.WriteLine("Account exists");
            }
            else if (!ifExists)
            {
                //if (db.TestTables.Contains<questionanswerexample>(test.questionAnswerID))
                //Add to database - add to the dbSet in Database Context, then save changes
                log.passwordHash = hashPassword(log.passwordHash);
                db.Login.Add(log);
                db.SaveChanges();

            }
            return RedirectToPage("./Index");
        }

        public logininfo findAccount(int index)
        {
            return Login[index];
        }

        public string hashPassword(string pass)
        {
            try
            {
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    byte[] bytes = System.Text.Encoding.ASCII.GetBytes(pass);

                    byte[] hashValue = mySHA256.ComputeHash(bytes);
                    return Convert.ToBase64String(hashValue);
                }
            }

            catch (Exception e)
            {
                return null;
            }
        }

    }

}