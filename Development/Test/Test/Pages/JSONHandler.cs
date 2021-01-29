using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

//to save custom questionnaires

namespace Test.Pages
{
    public class JSONHandler
    {
        string connectionString = "Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";

        String createTable = @"CREATE TABLE `20agileteam9db`.`jsonstore` (
          `jsonID` INT NOT NULL AUTO_INCREMENT,
          `jsonText` LONGTEXT NULL,
          PRIMARY KEY (`jsonID`));
          ";

        String queryString = "";

        public JSONHandler(string connectionString, string createTable, string queryString)
        {
            this.connectionString = connectionString;
            this.createTable = createTable;
            this.queryString = queryString;
        }

        public bool JsonSave(JSONObject jsonObject)
        {
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();



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
                            MySqlCommand sqlCmd = new MySqlCommand(queryString);
                            sqlCmd.Parameters.AddWithValue("@jsonString", jsonObject.jsonString);
                            sqlCmd.Connection = mySqlConnection;
                            sqlCmd.ExecuteNonQuery();
                            Console.Write("1");

                            return true;
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
                return false;
            }

            catch (Exception exception)

            {

                // Use the exception object to handle all other non-MySql specific errors
                return false;
            }

            return false;
        }

        public bool jsonRead()
        {
            return false;
        }

        public void jsonToString()
        {
            
        }
    }

    public class JSONObject
    {
        public int ID { get; set; }
        public string jsonString { get; set; }

        public JSONObject(string jsonString0)
        {
            ID = 0;
            this.jsonString = jsonString;
        }

        public void idSet(int set)
        {
            this.ID = set;
        }


    }
}
