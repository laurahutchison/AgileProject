using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;


namespace Test
{

    public class LoginModel : PageModel
    {
        private DatabaseContext db;

        [BindProperty]
        public logininfo log { get; set; }

        private readonly IConfiguration configuration;

        private string loggedIn;

        public LoginModel(DatabaseContext _db, IConfiguration configuration)
        {
            db = _db;
            this.configuration = configuration;
        }

        public List<logininfo> Login { get; set; }


        public void OnGet()
        {
            //loggedIn = GetSpecificClaim();
            Console.Write("hjkl");

        }

        public async Task<IActionResult> OnPostLogin()
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

            Console.WriteLine("testing");

            if (ifExists)
            {
                string fuckthis = hashPassword(log.passwordHash);
                if (findAccount(index).passwordHash == fuckthis)
                {
                    //set cookie
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, log.username),
                        //new Claim(ClaimTypes.Role, log.role),
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    
                    //debug
                    Console.WriteLine("dfghjkl;");
                    auth = true;
                    //return to logged in page
                    return RedirectToPage("/admin/index");
                }
            }
           
            // here we return to not logged in page
            return Page();
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