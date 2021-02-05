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
    [Table("response")]
    public class Response
    {
        [Key]
        public string responseID { get; set; }
        public int questionnaireID { get; set; }

        public string responseString { get; set; }
        [NotMapped]
        public List<string> sectionAnswerIds { get; set; }

        public Response()
        {

        }

        public override string ToString() => JsonSerializer.Serialize<Response>(this);
    }
}
