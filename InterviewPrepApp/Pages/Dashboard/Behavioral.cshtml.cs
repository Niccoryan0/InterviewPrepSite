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
    public class BehavioralModel : PageModel
    {
        public IBehavioralQ _questions { get; set; }
        public List<BehavioralQ> AllQs { get; set; }
        [BindProperty]
        public BehavioralViewModel Question { get; set; }

        public BehavioralModel(IBehavioralQ questions)
        {
            _questions = questions;
        }

        public async Task<IActionResult> OnGet()
        {
            AllQs = await _questions.GetBehavioralQs();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            BehavioralQ question = new BehavioralQ
            {
                Question = Question.Question
            };
            await _questions.Create(question);
            AllQs = await _questions.GetBehavioralQs();
            return Page();
        }

        public class BehavioralViewModel
        {
            public string Question { get; set; }
        }

    }
}