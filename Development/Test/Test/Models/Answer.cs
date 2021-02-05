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
    public class Answer
    {
        [Key]
        public string id { get; set; }
        public int sectionAnswerId { get; set; }
        public int questionId { get; set; }
       public string answersList { get; set; }
        public List<string> answers { get; set; }

        public Answer()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Answer>(this);
    }
}

