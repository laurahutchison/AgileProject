using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    [Table("responses")]
    public class Responses
    {
        [Key]
        public int responseID { get; set; }
        public int questionID { get; set; }
        public string responseDate { get; set; } = "";
        public string answersText { get; set; } = "";
    }
}
