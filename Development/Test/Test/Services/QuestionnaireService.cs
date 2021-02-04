using System;
using System.Collections.Generic;
using System.IO;
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

        public void addQuestionnaire(questionnaires questionnaire)
        {
            string json = questionnaire.ToString();
            File.WriteAllText(JsonFileName, json);
        }

        public IEnumerable<questionnaires> GetQuestionnaires()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<questionnaires[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        internal void addQuestionnaire(Test.Pages.Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }
    }
}
