using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Models;
using Test.Services;

namespace Test.Pages
{
    public class ProjectModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        public ProjectService _projectService;
        public UserService _userService;
        public Project project { get; private set; }

        public ProjectModel(ProjectService projectService, UserService userService)
        {
            _projectService = projectService;
            _userService = userService;
        }

        public void OnGet()
        {
            project = _projectService.GetProjects().First(x => x.id == id);
        }
    }
}
