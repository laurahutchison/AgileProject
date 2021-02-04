using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test.Models
{
    [Table("logininfo")]
    public class logininfo
    {
        [Key]
        public int accountID { get; set; }
        public string username { get; set; }
        public string passwordHash { get; set; }
    }
}
