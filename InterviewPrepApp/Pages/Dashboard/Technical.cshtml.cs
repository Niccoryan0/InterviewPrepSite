using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Questions.Dashboard
{
    [Authorize(Policy = "Contributors")]
    public class TechnicalModel : PageModel
    {
        public ITechnicalQ _questions { get; set; }
        public List<TechnicalQ> AllQs { get; set; }
        [BindProperty]
        public TechnicalViewModel Question { get; set; }


        public TechnicalModel(ITechnicalQ questions)
        {
            _questions = questions;
        }

        public async Task<IActionResult> OnGet()
        {
            AllQs = await _questions.GetTechnicalQs();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            TechnicalQ question = new TechnicalQ
            {
                Question = Question.Question,
                Answer = Question.Answer,
                Category = Question.Category
            };
            await _questions.Create(question);
            AllQs = await _questions.GetTechnicalQs();
            return Page();
        }

        public class TechnicalViewModel
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public string Category { get; set; }
        }

    }
}