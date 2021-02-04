using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace Test.Models
{
    [Table("questionnaires")]
    public class questionnaires
    {
        [Key]
        public int questionID { get; set; }

        public string title { get; set; }
        public string authors { get; set; }

        public string description { get; set; }

        //public int sectionCount { get; set; }

        public string questionnaire { get; set; }
        public DateTime datemade { get; set; }
        public string privacypolicy { get; set; }

        public int projectID { get; set; }

        public List<string> coAuthorIds { get; set; }

        //Cally's variables, to be changed over to the above etc for the database

        //public string id { get; set; }
        //public string authorId { get; set; }
        //public string projectId { get; set; }
        //public List<string> coAuthorIds { get; set; }
        //public List<string> sectionIds { get; set; }
        //public string title { get; set; }
        //public string description { get; set; }
        //public string image { get; set; }
        //public int sectionCount { get; set; }

        public string image { get; set; }

        /**
         * Want to add this wherever Survey Responses get submitted
         */
    }
}



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