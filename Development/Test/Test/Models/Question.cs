using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Question
    {
        public string id { get; set; }
        public string sectionId { get; set; }
        public string questionType { get; set; }
        public string question { get; set; }
        public List<string> answerOptions { get; set; }
        public List<string> answerIds{ get; set; }

        public Question()
        {

        }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);
    }
}
