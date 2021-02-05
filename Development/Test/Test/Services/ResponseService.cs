﻿using System;
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

        public Response GetResponseById(int id)
        {
            return GetResponses().First(x => Int32.Parse(x.responseID) == id);
        }

        public IEnumerable<Response> GetResponsesByQuestionnaire(int questionnaire)
        {
            return GetResponses().Where(x => x.questionnaireID == questionnaire);
        }
    }
}
