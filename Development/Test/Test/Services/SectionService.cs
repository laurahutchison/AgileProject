using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class SectionService
    {
        public SectionService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "sections.json"); }
        }

        public IEnumerable<Section> GetSections()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Section[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Section> GetSectionsByQuestionnaire(int questionnaire)
        {
            return GetSections().Where(x => x.questionnaireID == questionnaire);
        }

        public Section GetSectionById(int sectionID)
        {
            IEnumerable<Section> temp = GetSections().Where(x => Int32.Parse(x.id) == sectionID);
            return temp.FirstOrDefault(x => Int32.Parse(x.id) == sectionID);

        }
    }
}
