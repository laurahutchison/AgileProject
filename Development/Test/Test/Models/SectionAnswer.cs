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
    [Table("sectionanswer")]
    public class SectionAnswer
    {
        [Key]
        public string id { get; set; }
        public int responseId { get; set; }
        public int sectionId { get; set; }
        public string answerIDs { get; set; }
        [NotMapped]
        public List<string> answerIds { get; set; }

        public SectionAnswer()
        {
            
        }

        public override string ToString() => JsonSerializer.Serialize<SectionAnswer>(this);
    }
}
