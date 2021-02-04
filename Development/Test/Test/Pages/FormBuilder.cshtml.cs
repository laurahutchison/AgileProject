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


        }
    }
}


