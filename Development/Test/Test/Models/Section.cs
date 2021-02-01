using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Section
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public int questionCount { get; set; }

        public List<Question> questions { get; set; } = new List<Question>();
        
        public Section()
        {
        }

        public void addSection(string name)
        {
            questionCount = questions.Count;
            questionCount++;
            questions.Add(new Question());
        }

        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }
}
