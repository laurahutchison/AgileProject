using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Test.Models
{   
    [Table("sections")]
    public class Section
    {
        [Key]
        public string id { get; set; }
        //public string name { get; set; }
        //public string questionnaireId { get; set; }
        //public string title { get; set; }
        public string description { get; set; }

        public string title { get; set; }

        public int questionCount { get; set; }


        [NotMapped]
        public SortedList questions { get; set; }

        //do method to delimit string??
        [NotMapped]
        public List<string> questionIds { get; set; }


        public int questionnaireID { get; set; }
        
        public Section()
        {
        }

        //public void addSection(string name)
        //{
        //    questionCount = questions.Count;
        //    questionCount++;
        //    questions.Add((questionCount), new Section());
        //}

        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }
}
