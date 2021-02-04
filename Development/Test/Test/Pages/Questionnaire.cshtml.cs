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
    public class QuestionnaireModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string subpage { get; set; }

        public QuestionnaireService _questionnaireService { get; set; }
        public SectionService _sectionService { get; set; }
        public QuestionService _questionService { get; set; }
        public UserService _userService { get; set; }
        public Questionnaire questionnaire { get; set; }
        public IEnumerable<Section> sections { get; set; }
        public IEnumerable<Question> questions { get; set; }
        public IEnumerable<User> users { get; set; }

        public QuestionnaireModel(QuestionnaireService questionnaireService, SectionService sectionService, QuestionService questionService, UserService userService)
        {
            _questionnaireService = questionnaireService;
            _sectionService = sectionService;
            _questionService = questionService;
            _userService = userService;
        }

        public void OnGet()
        {
            questionnaire = _questionnaireService.GetQuestionnaireById(id);
            sections = _sectionService.GetSectionsByQuestionnaire(id);
            users = _userService.GetUsersByQuestionnaire(id);
        }
    }
}
