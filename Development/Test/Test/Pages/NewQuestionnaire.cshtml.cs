using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

//Code partioned from godaddy.com

namespace Test.Pages
{
    public class QuestionnaireModel : PageModel
    {
        string connectionString = @"Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";
        public string answer1 { get; set; }
        public string answer2 { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();

            mySqlConnection.ConnectionString = connectionString;
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();


                    switch (mySqlConnection.State)

                    {

                        case System.Data.ConnectionState.Open:

                            // Connection has been made
                            //THIS WORKS THIS WORKS THIS WORKS THIS WORKS READ BY NESTED FOR LOOP THANK YOU STACKOVERFLOW
                            //THE PRIMARY KEY questionAnswerID MUST BE UNIQUE, same with any other unique key or it will return an error - exception handling must be used
                            string fff = @"INSERT INTO Customers (questionAnswerID, questionID, answer1, answer2) VALUES('2347', '45678', 'no', 'no');";
                            MySqlCommand sqlCmd = new MySqlCommand("INSERT INTO `20agileteam9db`.`questionanswerexample` (questionAnswerID, questionID, answer1, answer2) VALUES(NULL, '45678', '" + answer1 + "', '" + answer2 + "');", mySqlConnection);
                            sqlCmd.Connection = mySqlConnection;
                            sqlCmd.Parameters.AddWithValue("@answer1", answer1);
                            sqlCmd.Parameters.AddWithValue("@answer2", answer2);

                            //sqlCmd.Connection.Open();
                            sqlCmd.ExecuteNonQuery();
                            //mySqlConnection.Close();
                            Console.Write("hsjskd");

                            Console.Write("1");
                            break;

                        case System.Data.ConnectionState.Closed:
                            break;
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
                break;
                // Use the mySqlException object to handle specific MySql errors

            }

            catch (Exception exception)

            {
                break;
                // Use the exception object to handle all other non-MySql specific errors

            }
        }


    }
}
