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
    [Table("user")]
    public class User
    {
        [Key]
        public string userID { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        [NotMapped]
        public List<string> projectIds { get; set; }
        [NotMapped]
        public List<int> questionnaireIds { get; set; }

        public User()
        {
        }

        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
}