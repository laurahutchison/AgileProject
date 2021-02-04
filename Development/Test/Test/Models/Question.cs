using System;
using System.Text.Json;

namespace Test.Models
{
    public class Question
    {
        public string id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public int projectID { get; set; }

        public int sectionID { get; set; }

        public Question()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);
    }
}
