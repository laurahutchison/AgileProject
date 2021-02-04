using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class Response
    {
        public string id { get; set; }
        public string questionnaireId { get; set; }
        public List<string> sectionAnswerIds { get; set; }

        public Response()
        {

        }

        public override string ToString() => JsonSerializer.Serialize<Response>(this);
    }
}
