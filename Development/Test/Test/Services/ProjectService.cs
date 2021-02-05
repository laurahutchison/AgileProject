using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json"); }
        }

        public IEnumerable<Project> GetProjects()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void NewProject()
        {
            var projects = GetProjects();

            var query = projects.Count();
            string id = (query + 1).ToString();

            Project project = new Project();

            project.id = id;
            project.authorId = "1";
            project.title = ("Project " + id);
            project.description = "";
            project.coAuthorIds = new List<string>();
            project.questionnaireIds = new List<string>();
            project.image = "";
            Console.WriteLine(project);
            var projects2 = projects.ToList();
            projects2.Add(project);
            Console.WriteLine("\n\n\n\n\n");
            foreach(var Project in projects)
            {
                Console.WriteLine(Project);
            }

            PostProjects(projects2);
        }

        public void UpdateProject(Project project)
        {
            var projects = GetProjects();
            var projects2 = projects.ToList();
            int count = 0;

            foreach (var project2 in projects)
            {
                if(project2.id == project.id)
                {
                    projects2[count] = project;
                    break;
                }

                count++;
            }

            PostProjects(projects2);
        }

        public void PostProjects(IEnumerable<Project> projects)
        {
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Project>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    projects);
            }
        }
    }
}
