using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Answer
    {
        public string id { get; set; }
        public string sectionAnswerId { get; set; }
        public string questionId { get; set; }
        public List<string> answers { get; set; }

        public Answer()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Answer>(this);
    }
}

