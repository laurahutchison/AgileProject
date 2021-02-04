using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class SectionAnswer
    {
        public string id { get; set; }
        public string responseId { get; set; }
        public string sectionId { get; set; }
        public List<string> answerIds { get; set; }

        public SectionAnswer()
        {
            
        }

        public override string ToString() => JsonSerializer.Serialize<SectionAnswer>(this);
    }
}
