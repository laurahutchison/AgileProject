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
    public class ProjectsModel : PageModel
    {
        public ProjectService _projectService;
        public UserService _userService;
        public ImageService _imageService;
        public IEnumerable<Project> projects { get; private set; }

        public ProjectsModel(ProjectService projectService, UserService userService, ImageService imageService)
        {
            _projectService = projectService;
            _userService = userService;
            _imageService = imageService;
        }

        public void OnGet()
        {
            projects = _projectService.GetProjects();
        }

        public IActionResult OnPost()
        {
            _projectService.NewProject();
            projects = _projectService.GetProjects();
            return Page();
        }
    }
}
