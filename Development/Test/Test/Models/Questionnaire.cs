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
        public string authorId { get; set; }
        public string projectId { get; set; }
        public List<string> coAuthorIds { get; set; }
        public List<string> sectionIds { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int sectionCount { get; set; }

        public Questionnaire()
        {

        }

        //public void AddSection(string name)
        //{
        //    sectionCount = sectionIds.Count;
        //    sectionCount++;
        //    sectionIds.Add(new Section());
        //}

        public override string ToString() => JsonSerializer.Serialize<Questionnaire>(this); 
    }
}
