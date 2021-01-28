using System;
using System.Collections;
using System.Text.Json;

namespace Test.Models
{
    public class Questionnaire
    {
        public string id { get; set; }
        public string author { get; set; }
        public string title { get; set; }

        public int sectionCount { get; set; }

        public SortedList sections { get; set; } = new SortedList();

        public Questionnaire()
        {
        }

        public void addSection(string name)
        {
            sectionCount = sections.Count;
            sectionCount++;
            sections.Add((sectionCount), new Section());
        }

        public override string ToString() => JsonSerializer.Serialize<Questionnaire>(this); 
    }
}
