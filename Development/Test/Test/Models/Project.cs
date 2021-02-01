using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class Project
    {
        public string id { get; set; }
        public User author { get; set; }
        public List<User> coAuthor { get; set; }
        public List<Questionnaire> questionnaires { get; set; }

        public Project()
        {
        }
    }
}
