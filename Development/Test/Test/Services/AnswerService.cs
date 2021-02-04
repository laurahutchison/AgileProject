using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class AnswerService
    {
        public AnswerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "answers.json"); }
        }

        public IEnumerable<Answer> GetAnswers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Answer[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Answer> GetAnswersBySectionAnswer(int sectionAnswer)
        {
            return GetAnswers().Where(x => x.sectionAnswerId == sectionAnswer);
        }
    }
}
