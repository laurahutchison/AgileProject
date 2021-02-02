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
        public IEnumerable<Project> projects { get; private set; }

        public ProjectsModel(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public void OnGet()
        {
            projects = _projectService.GetProjects();
        }
    }
}
