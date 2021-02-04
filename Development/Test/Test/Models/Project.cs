using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Project
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string authorId { get; set; }
        public List<string> coAuthorIds { get; set; }
        public List<string> questionnaireIds { get; set; }
        public string image { get; set; }

        public Project()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Project>(this);
    }
}
