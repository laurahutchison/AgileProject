using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class QuestionService
    {
        public QuestionService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "questions.json"); }
        }

        public IEnumerable<Question> GetQuestions()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Question[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Question> GetQuestionsBySection(int section)
        {
            return GetQuestions().Where(x => x.sectionID == section);
        }

        public Question GetQuestionById(int questionID)
        {
            IEnumerable<Question> temp = GetQuestions().Where(x => Int32.Parse(x.id) == questionID);
            return temp.FirstOrDefault(x => Int32.Parse(x.id) == questionID);

        }
    }
}