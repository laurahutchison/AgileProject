using System;
using System.Collections;
using System.Text.Json;

namespace Test.Models
{
    public class Section
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public int questionCount { get; set; }

        public SortedList questions { get; set; } = new SortedList();
        
        public Section()
        {
        }

        public void addSection(string name)
        {
            questionCount = questions.Count;
            questionCount++;
            questions.Add((questionCount), new Section());
        }

        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }
}
