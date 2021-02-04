using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Logging;
using Test.Services;
using Test.Models;

//Code partioned from godaddy.com

namespace Test.Pages
{
    public class FormBuilderModel : PageModel
    {
        private readonly ILogger<FormBuilderModel> _logger;
        public QuestionnaireService questionnaireService;
        private DatabaseContext db;
        public List<questionnaires> questionnaireList;
        public questionnaires holder { get; set; }

        public FormBuilderModel(QuestionnaireService _questionnaireService)
        {
            //_logger = logger;
            questionnaireService = _questionnaireService;
        }

        //string connectionString = "Server=silva.computing.dundee.ac.uk;Database=20agileteam9db;Uid=20agileteam9;Pwd=3489.at9.9843;";

        [BindProperty]
        public questionnaires questionnaire { get; set; }

        //public void OnPostDetails()
        //{
        //    //using var outputStream = File.OpenWrite("~/data/test.json");
        //    questionnaireService.addQuestionnaire(questionnaire);
        //}

        public void OnPost()
        {


            //    MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection();

            //    mySqlConnection.ConnectionString = connectionString;
            //    try
            //    {
            //        using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            //        {
            //            mySqlConnection.Open();


            //            switch (mySqlConnection.State)

            //            {

            //                case System.Data.ConnectionState.Open:

            //                    // Connection has been made

            //                    string fff = @"INSERT INTO Customers (questionAnswerID, questionID, answer1, answer2) VALUES('234567', '45678', 'no', 'no');";
            //                    MySqlCommand sqlCmd = new MySqlCommand(@"INSERT INTO `20agileteam9db`.`questionanswerexample` (questionAnswerID, questionID, answer1, answer2) VALUES('234567', '45678', 'no', 'no');");
            //                    sqlCmd.Connection = mySqlConnection;
            //                    sqlCmd. ExecuteNonQuery();
            //                    Console.Write("hsjskd");

            //                    Console.Write("1");
            //                    break;

            //                case System.Data.ConnectionState.Closed:

            //                    // Connection could not be made, throw an error
            //                    Console.Write("2");
            //                    throw new Exception("The database connection state is Closed");

            //                default:

            //                    // Connection is actively doing something else

            //                    break;
            //                    //MySqlCommand sqlCmd = new MySqlCommand("ProductAddOrEdit", sqlCon);
            //                    //sqlCmd.CommandType = CommandType.StoredProcedure;
            //                    //sqlCmd.ExecuteNonQuery();
            //            }
            //        }
            //    }

            //    catch (MySql.Data.MySqlClient.MySqlException mySqlException)

            //    {

            //        // Use the mySqlException object to handle specific MySql errors

            //    }

            //    catch (Exception exception)

            //    {

            //        // Use the exception object to handle all other non-MySql specific errors

            //    }
            //}
        }
    }
}


