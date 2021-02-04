using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test.Models
{
    [Table("questionnaires")]
    public class questionnaires
    {
        [Key]
        public int questionID { get; set; }

        public string questionNAME { get; set; }
        public string authors { get; set; }

       //public int sectionCount { get; set; }

        public string questionnaire { get; set; }
        public DateTime datemade { get; set; }
        public string privacypolicy { get; set; }

        //public SortedList sections { get; set; } = new SortedList();

        //public questionnaires()
        //{
        //}

        //public void AddSection(string name)
        //{
        //    sectionCount = sections.Count;
        //    sectionCount++;
        //    sections.Add((sectionCount), new Section());
        //}

        //public override string ToString() => JsonSerializer.Serialize<questionnaires>(this); 
    }
}
