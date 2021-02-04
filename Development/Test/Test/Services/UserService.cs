using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Test.Models;

namespace Test.Services
{
    public class UserService
    {
        public UserService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName(string file)
        {
            return Path.Combine(WebHostEnvironment.WebRootPath, "data", file);
        }

        public IEnumerable<User> GetUsers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName("users.json")))
            {
                return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<User> GetUsersByQuestionnaire(string questionnaire)
        {
            return GetUsers().Where(x => x.questionnaireIds.Contains(questionnaire));
        }

        public User GetUserById(string id)
        {
            return GetUsers().First(x => x.id == id);
        }

        public string GetNameById(string id)
        {
            User user = GetUserById(id);
            string name = user.firstName + " " + user.surname;
            return name;
        }

        public string GetNamesFromList(List<string> ids)
        {
            string names = "";

            foreach (var id in ids)
            {
                if (id != ids.Last())
                {
                    names += (GetNameById(id) + " / ");
                }
                else if (id == ids.Last())
                {
                    names += GetNameById(id);
                }
            }

            if (names == "")
            {
                names = "n/a";
            }

            return names;
        }

        public string GetEmailById(string id)
        {
            User user = GetUserById(id);
            return user.email;
        }

        public string GetEmailsFromList(List<string> ids)
        {
            string emails = "";

            foreach (var id in ids)
            {
                if (id != ids.Last())
                {
                    emails += (GetEmailById(id) + " / ");
                }
                else if (id == ids.Last())
                {
                    emails += GetEmailById(id);
                }
            }

            if (emails == "")
            {
                emails = "n/a";
            }

            return emails;
        }
    }
}
