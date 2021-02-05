using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;
using Newtonsoft.Json.Linq;
using System.Linq;


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

        //public void addProject(Project project)
        //{
        //    string json = project.ToString();
        //    File.WriteAllText(JsonFileName(""), json);
        //}

        public IEnumerable<Project> GetProjects()
        {

            // private string sPath;
            ////sPath = Environment.CurrentDirectory.ToString();

            //JObject o1 = JObject.Parse(System.IO.File.ReadAllText("projects.json"));
            // string test2 = new jsonstore(0, o1.ToString(Newtonsoft.Json.Formatting.None));
            //Project project = o1.ToObject<Project>();



        //    using (var jsonFileReader = File.OpenText(JsonFileName("projects.json")))
        //{
        // return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(),
        //       new JsonSerializerOptions
        //      {
        //     PropertyNameCaseInsensitive = true
        //         });
        // }

            using (var jsonFileReader = File.OpenText(JsonFileName("projects.json")))
            {
                var serializeOptions = new JsonSerializerOptions();

                serializeOptions.PropertyNameCaseInsensitive = true;

                serializeOptions.Converters.Add(new Int32Converter());

                return JsonSerializer.Deserialize<Project[]>
                                     (jsonFileReader.ReadToEnd(),
                   serializeOptions);
            }
        }

        //internal void addProject(Test.Pages.Questionnaire questionnaire)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
