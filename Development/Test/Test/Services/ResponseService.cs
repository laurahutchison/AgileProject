using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class ResponseService
    {
        public ResponseService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "responses.json"); }
        }

        public IEnumerable<Response> GetResponses()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Response[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public Response GetResponseById(string id)
        {
            return GetResponses().First(x => x.id == id);
        }

        public IEnumerable<Response> GetResponsesByQuestionnaire(string questionnaire)
        {
            return GetResponses().Where(x => x.questionnaireId == questionnaire);
        }
    }
}
