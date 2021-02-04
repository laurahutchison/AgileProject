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
    public class InfoSheetModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public QuestionnaireService _questionnaireService { get; set; }
        public Questionnaire questionnaire { get; set; }

        public InfoSheetModel(QuestionnaireService questionnaireService)
        {

            _questionnaireService = questionnaireService;
        }

        public void OnGet()
        {
            questionnaire = _questionnaireService.GetQuestionnaireById(id);
        }
    }
}
