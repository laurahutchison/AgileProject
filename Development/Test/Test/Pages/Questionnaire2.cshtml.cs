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
    public class Questionnaire2Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        public QuestionnaireService _questionnaireService { get; set; }
        public SectionService _sectionService { get; set; }
        public QuestionService _questionService { get; set; }
        public UserService _userService { get; set; }
        public ResponseService _responseService { get; set; }
        public SectionAnswerService _sectionAnswerService { get; set; }
        public AnswerService _answerService { get; set; }
        public Questionnaire questionnaire { get; set; }
        public IEnumerable<Section> sections { get; set; }
        public IEnumerable<Question> questions { get; set; }
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Response> responses { get; set; }
        public IEnumerable<SectionAnswer> sectionAnswers { get; set; }
        public IEnumerable<Answer> answers { get; set; }
        public Section section { get; set; }
        public Question question { get; set; }

        public Questionnaire2Model(QuestionnaireService questionnaireService,
            SectionService sectionService, QuestionService questionService,
            UserService userService, ResponseService responseService,
            SectionAnswerService sectionAnswerService, AnswerService answerService)
        {
            _questionnaireService = questionnaireService;
            _sectionService = sectionService;
            _questionService = questionService;
            _userService = userService;
            _responseService = responseService;
            _sectionAnswerService = sectionAnswerService;
            _answerService = answerService;
        }

        public void OnGet()
        {
            questionnaire = _questionnaireService.GetQuestionnaireById(id);
            sections = _sectionService.GetSectionsByQuestionnaire(id);
            users = _userService.GetUsersByQuestionnaire(id);
        }

        public void OnPost()
        {

        }
    }
}
