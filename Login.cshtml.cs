using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test
{

    public class LoginModel : PageModel
    {

        //placeholder credentials - to be replaced with database stuff
        //usernames[1] correlates to passwords[1], etc
        string[] usernames = { "cactus", "sheep", "jane-doe"};
        string[] passwords = { "ouch", "baa", "password" };


        public void OnGet()
        {
         
        }

        public void OnPost()
        {
            //store user input in username
            var username = Request.Form["Username"];
            //view data allows access to variable from html
            ViewData["username"] = $"{username}";

            //store user input in password
            var password = Request.Form["Password"];
            ViewData["password"] = $"{password}";

            //true if username and password are correct
            Boolean auth = false;
            

            for (int i = 0; i < 3; i++)
            {
                //checks that username exists and matching password is correct
                if(Convert.ToString(ViewData["username"]) == usernames[i] && Convert.ToString(ViewData["password"]) == passwords[i])
                {
                    auth = true;

                }
            }

            ViewData["auth"] = $"{auth}";

           
        }
        
     
        
        
    }
}