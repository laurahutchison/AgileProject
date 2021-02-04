using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Section
    {
        public string id { get; set; }
        public string questionnaireId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> questionIds { get; set; }

        public int questionCount { get; set; }
        
        public Section()
        {
        }

        //public void addSection(string name)
        //{
        //    questionCount = questions.Count;
        //    questionCount++;
        //    questions.Add(new Question());
        //}

        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }
}
