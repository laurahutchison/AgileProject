using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class SectionAnswer
    {
        public int id { get; set; }
        public int responseId { get; set; }
        public int sectionId { get; set; }
        public List<string> answerIds { get; set; }

        public SectionAnswer()
        {
            
        }

        public override string ToString() => JsonSerializer.Serialize<SectionAnswer>(this);
    }
}
