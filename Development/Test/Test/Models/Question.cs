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
    [Table("question")]
    public class Question
    {
        [Key]
        public string id { get; set; }
        public string question { get; set; }

        public int projectID { get; set; }

        public int sectionID { get; set; }
        public string answerIDS { get; set; }
        public string answerOPTIONS { get; set; }

        [NotMapped]
        public List<string> answerOptions { get; set; }
        [NotMapped]
        public List<string> answerIds { get; set; }

        public Question()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);
    }
}
