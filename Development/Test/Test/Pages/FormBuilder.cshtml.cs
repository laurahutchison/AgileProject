using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

//Code partioned from godaddy.com

namespace Test.Pages
{
    public class QuestionnaireModel : PageModel
    {
        string connectionString = "Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";

        [BindProperty]
        public Questionnaire questionnaire { get; set; } = new Questionnaire();

        public void OnPostDetails(string author, string title)
        {
        }

        public void OnPost()
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

                            string fff = @"INSERT INTO Customers (questionAnswerID, questionID, answer1, answer2) VALUES('234567', '45678', 'no', 'no');";
                            MySqlCommand sqlCmd = new MySqlCommand(@"INSERT INTO `20agileteam9db`.`questionanswerexample` (questionAnswerID, questionID, answer1, answer2) VALUES('234567', '45678', 'no', 'no');");
                            sqlCmd.Connection = mySqlConnection;
                            sqlCmd. ExecuteNonQuery();
                            Console.Write("hsjskd");

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

    public class Questionnaire
    {
        public string id { get; set; } = "";
        public string author { get; set; }
        public string title { get; set; }

        public int sectionCount { get; set; } = 0;

        public SortedList sections { get; set; } = new SortedList();

        public void AddSection(string name)
        {
            sectionCount = sections.Count;
            sectionCount++;
            sections.Add((sectionCount), new Section());
        }

        public override string ToString() => JsonSerializer.Serialize<Questionnaire>(this);
    }

    public class Section
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public int questionCount { get; set; }

        public SortedList questions { get; set; } = new SortedList();

        public void AddQuestion(string name)
        {
            questionCount = questions.Count;
            questionCount++;
            questions.Add((questionCount), new Question());
        }

        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }

    public class Question
    {
        public string id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);
    }
}
