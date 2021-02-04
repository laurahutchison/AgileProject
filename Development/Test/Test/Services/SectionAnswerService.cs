using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class SectionAnswerService
    {
        public SectionAnswerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "sectionAnswers.json"); }
        }

        public IEnumerable<SectionAnswer> GetSectionAnswers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<SectionAnswer[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<SectionAnswer> GetSectionAnswersByResponse(int response)
        {
            return GetSectionAnswers().Where(x => x.responseId == response);
        }
    }
}
