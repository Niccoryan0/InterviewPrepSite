using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Questions
{
    [AllowAnonymous]
    public class TechnicalModel : PageModel
    {
        public ITechnicalQ _questions { get; set; }
        public List<int> NumbersUsed { get; set; }
        [BindProperty]
        public TechnicalViewModel Question { get; set; }

        public TechnicalModel(ITechnicalQ questions)
        {
            _questions = questions;
            NumbersUsed = new List<int>();
        }

        public async Task<IActionResult> OnGet()
        {
            await GetNewQuestion();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            await GetNewQuestion();
            return Page();
        }

        public async Task GetNewQuestion()
        {
            var questions = await _questions.GetTechnicalQs();
            Random rand = new Random();
            int num = rand.Next(questions.Count);
            int i = 0;
            while (NumbersUsed.Contains(num))
            {
                i++;
                if (i == questions.Count)
                {
                    NumbersUsed = new List<int>();
                }
                num = rand.Next(questions.Count);
            }
            NumbersUsed.Add(num);
            Question = new TechnicalViewModel()
            {
                Question = questions[num].Question,
                Answer = questions[num].Answer,
                Category = questions[num].Category
            };
        }

        public class TechnicalViewModel
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public string Category { get; set; }
        }
    }
}