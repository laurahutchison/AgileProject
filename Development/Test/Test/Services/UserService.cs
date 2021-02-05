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

        public IEnumerable<User> GetUsersByQuestionnaire(int questionnaire)
        {
            return GetUsers().Where(x => x.questionnaireIds.Contains(questionnaire));
        }

        public User GetUserByID(string id)
        {
            return GetUsers().First(x => x.userID == id);
        }

        public string GetNameByID(string id)
        {
            User user = GetUserByID(id);
            string name = user.firstName + " " + user.surname;
            return name;
        }

        public string GetNamesFromList(List<int> ids)
        {
            string names = "";

            foreach (var id in ids)
            {
                if (id != ids.Last())
                {
                    names += (GetNameByID(id.ToString()) + ", ");
                }
                else if (id == ids.Last())
                {
                    names += GetNameByID(id.ToString());
                }
            }

            if (names == "")
            {
                names = "n/a";
            }

            return names;
        }
    }
}
