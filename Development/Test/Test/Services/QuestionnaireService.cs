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

        public Questionnaire GetQuestionnaireById(string id)
        {
            return GetQuestionnaires().First(x => x.id == id);
        }

        public IEnumerable<Questionnaire> GetQuestionnairesByProject(string project)
        {
            return GetQuestionnaires().Where(x => x.projectId == project);
        }

        public string NewQuestionnaire(string project)
        {
            var questionnaires = GetQuestionnaires();

            var query = questionnaires.Count();
            string id = (query + 1).ToString();

            Questionnaire questionnaire = new Questionnaire();

            questionnaire.id = id;
            questionnaire.authorId = "1";
            questionnaire.title = ("Questionnaire " + id);
            questionnaire.description = "";
            questionnaire.projectId = project;
            questionnaire.coAuthorIds = new List<string>();
            questionnaire.sectionIds = new List<string>();
            questionnaire.image = "";
            questionnaire.sectionCount = 0;

            var questionnaires2 = questionnaires.ToList();
            questionnaires2.Add(questionnaire);
            PostQuestionnaires(questionnaires2);
            return questionnaire.id;
        }

        public void PostQuestionnaires(IEnumerable<Questionnaire> questionnaires)
        {
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Questionnaire>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    questionnaires);
            }
        }
    }
}
