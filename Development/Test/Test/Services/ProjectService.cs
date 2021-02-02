using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class ProjectService
    {
        public ProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName(string file)
        {
            return Path.Combine(WebHostEnvironment.WebRootPath, "data", file);
        }

        public void addProject(Project project)
        {
            string json = project.ToString();
            File.WriteAllText(JsonFileName(""), json);
        }

        public IEnumerable<Project> GetProjects()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName("projects.json")))
            {
                return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        internal void addProject(Test.Pages.Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }
    }
}
