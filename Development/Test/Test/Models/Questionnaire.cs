using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Test.Models
{
    public class Questionnaire
    {
        public string id { get; set; }
        public User author { get; set; }
        public string title { get; set; }
        public List<User> coAuthors { get; set; }

        public int sectionCount { get; set; } = 0;

        public List<Section> sections { get; set; } = new List<Section>();

        public Questionnaire()
        {

        }

        public void AddSection(string name)
        {
            sectionCount = sections.Count;
            sectionCount++;
            sections.Add(new Section());
        }

        public override string ToString() => JsonSerializer.Serialize<Questionnaire>(this); 
    }
}
