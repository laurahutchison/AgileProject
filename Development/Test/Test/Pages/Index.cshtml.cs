using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        string connectionString = @"Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new

            MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnection.ConnectionString = connectionString;
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();


                    switch (mySqlConnection.State)

                    {

                        case System.Data.ConnectionState.Open:

                            // Connection has been made
                            Console.Write("1");
                            break;

                        case System.Data.ConnectionState.Closed:

                            // Connection could not be made, throw an error
                            Console.Write("2");
                            throw new Exception("The database connection state is Closed");

                        default:

                            // Connection is actively doing something else

                            break;
                            //MySqlCommand sqlCmd = new MySqlCommand("ProductAddOrEdit", sqlCon);
                            //sqlCmd.CommandType = CommandType.StoredProcedure;
                            //sqlCmd.ExecuteNonQuery();
                    }
                }
            }

            catch (MySql.Data.MySqlClient.MySqlException mySqlException)

            {

                // Use the mySqlException object to handle specific MySql errors

            }

            catch (Exception exception)

            {

                // Use the exception object to handle all other non-MySql specific errors

            }
        }
    }
}


