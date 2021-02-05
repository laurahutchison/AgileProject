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
    [Table("project")]
    public class Project
    {
        [Key]
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string authorId { get; set; }

        [NotMapped]
        public List<int> coAuthorIds { get; set; }
        public List<int> questionnaireIds { get; set; }
        //public string image { get; set; }

        public Project()
        {
        }
    }
}
