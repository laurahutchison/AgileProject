using System;
using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    [Table("jsonstore")]
    public class jsonstore
    {

        [Key]

        public int jsonID { get; set; }
        public string jsonText {get;set;}

        public jsonstore(int jsonID, string jsonText)
        {
            this.jsonID = jsonID;
            this.jsonText = jsonText;
        }
    }
}
