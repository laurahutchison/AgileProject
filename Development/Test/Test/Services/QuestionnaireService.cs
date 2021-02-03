using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class QuestionnaireService
    {
        public QuestionnaireService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get;  }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "questionnaires.json"); }
        }

        //public void addQuestionnaire(Questionnaire questionnaire)
        //{
        //    string json = questionnaire.ToString();
        //    File.WriteAllText(JsonFileName, json);
        //}

        public IEnumerable<Questionnaire> GetQuestionnaires()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Questionnaire[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Questionnaire> GetQuestionnairesByProject(string project)
        {
            return GetQuestionnaires().Where(x => x.projectId == project);
        }

        //internal void addQuestionnaire(Test.Pages.Questionnaire questionnaire)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
