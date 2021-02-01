using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public List<Project> projects { get; set; }
        public List<Questionnaire> questionnaires { get; set; }

        public User()
        {
        }
    }
}
