using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test.Models
{
    [Table("questionanswerexample")]
    public class questionanswerexample
    {
        [Key]
        public int questionAnswerID { get; set; }
        public int questionID { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
    }
}
