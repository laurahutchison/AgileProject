using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Response
    {
        public int id { get; set; }
        public int questionnaireId { get; set; }
        public List<string> sectionAnswerIds { get; set; }

        public Response()
        {

        }

        public override string ToString() => JsonSerializer.Serialize<Response>(this);
    }
}
