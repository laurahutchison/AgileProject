using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.Data;

namespace Test.Pages
{
    public class Index1Model : PageModel
    {
        string connectionString = "Server=silva.computing.dundee.ac.uk; Database=20agileteam9db; Uid=20agileteam9; Pwd=3489.at9.9843;";

        MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();

        public void OnGet()  
        {

            

        }
        public void OnPost()
        {
            //MUST DO THIS WHEN BUTTON IS PRESSED LOOK AT RAZOR PAGES RESOURCES???
            Console.Write("dfghjkl");

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

                            /*DROP TABLE if exists `questionanswerexample`();
                            CREATE TABLE `questionanswerexample`
                            (questionAnswerID INT NOT NULL,
                            questionID INT NOT NULL,
                            answer1 VARCHAR(45),
                            answer2 VARCHAR(45),
                            PRIMARY KEY(questionAnswerID)) COLLATE = 'utf8_general_ci' ENGINE = InnoDB;*/

                            string sickofthis = "INSERT INTO `Reservation`(`questionAnswerID`, `questionID`, `answer1`, `answer2`) VALUES(`34567`, `23456`, `yes`, `no`)";
                            MySqlCommand Create_table = new MySqlCommand(sickofthis, mySqlConnection);
                            //Create_table.Connection.Open();
                            Create_table.ExecuteNonQuery();
                            //Create_table.Connection.Close();

                            MySqlCommand Amend_table = new MySqlCommand(@"
                            INSERT INTO questionanswerexample (questionAnswerID, questionID, answer1, answer2)
                            VALUES ('1234', '1222', 'Skagen 21', 'Stavanger')", mySqlConnection);
                            Create_table.Connection.Open();
                            Amend_table.ExecuteNonQuery();
                            Amend_table.Connection.Close();
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

    //protected void btnSave_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
    //        {
    //            sqlCon.Open();
    //            MySqlCommand sqlCmd = new MySqlCommand("ProductAddOrEdit", sqlCon);
    //            sqlCmd.CommandType = CommandType.StoredProcedure;
    //            sqlCmd.Parameters.AddWithValue("_productid", Convert.ToInt32(hfProductID.Value == "" ? "0" : hfProductID.Value));
    //            sqlCmd.Parameters.AddWithValue("_product", txtProduct.Text.Trim());
    //            sqlCmd.Parameters.AddWithValue("_price", Convert.ToDecimal(txtPrice.Text.Trim()));
    //            sqlCmd.Parameters.AddWithValue("_count", Convert.ToInt32(txtCount.Text.Trim()));
    //            sqlCmd.Parameters.AddWithValue("_description", txtDescription.Text.Trim());
    //            sqlCmd.ExecuteNonQuery();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //}

}
