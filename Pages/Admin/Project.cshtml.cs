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
        public int id { get; set; }

        public ProjectService _projectService;
        public UserService _userService;
        public QuestionnaireService _questionnaireService;
        public Project project { get; private set; }
        public IEnumerable<questionnaires> Questionnaires { get; private set; }
        [BindProperty]
        public List<questionnaires> Questionnaires2 { get; set; }

        public ProjectModel(ProjectService projectService, UserService userService, QuestionnaireService questionnaireService)
        {
            _projectService = projectService;
            _userService = userService;
            _questionnaireService = questionnaireService;
        }

        public void OnGet()
        {
            project = _projectService.GetProjects().First(x => x.id == id);
            Questionnaires = _questionnaireService.GetQuestionnairesByProject(id);
        }
    }
}
