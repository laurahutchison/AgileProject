using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.IO;

namespace Test.Pages
{
    public class BLOBModel : PageModel
    {

        string connectionString = "Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";

        public void OnGet()
        {
        }

        public void OnPush()
        {
            JSONObject jsonObject = new JSONObject("test");

        }


    }
}
