using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test.Models
{
    [Table("questionnaire")]
    public class Questionnaire
    {
        [Key]
        public string id { get; set; } = "";
        public string author { get; set; } = "";
        public string title { get; set; } = "";

        public int sectionCount { get; set; } = 0;

        public SortedList sections { get; set; } = new SortedList();

        public Questionnaire()
        {
        }

        public void AddSection(string name)
        {
            sectionCount = sections.Count;
            sectionCount++;
            sections.Add((sectionCount), new Section());
        }

        public override string ToString() => JsonSerializer.Serialize<Questionnaire>(this); 
    }
}
