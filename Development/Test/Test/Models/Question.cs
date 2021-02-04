using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Question
    {
        public int id { get; set; }
        public string question { get; set; }

        public int projectID { get; set; }

        public int sectionID { get; set; }

        public List<string> answerOptions { get; set; }
        public List<string> answerIds { get; set; }

        public Question()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);
    }
}
