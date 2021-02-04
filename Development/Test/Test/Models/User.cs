using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Test.Models
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public string image { get; set; }
        public List<string> projectIds { get; set; }
        public List<string> questionnaireIds { get; set; }

        public User()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
}
