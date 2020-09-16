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
    public class WhiteboardModel : PageModel
    {
        public IWhiteboardQ _questions { get; set; }
        public List<int> NumbersUsed { get; set; }
        [BindProperty]
        public WhiteboardViewModel Question { get; set; }

        public WhiteboardModel(IWhiteboardQ questions)
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
            var questions = await _questions.GetWhiteboardQs();
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
            Question = new WhiteboardViewModel()
            {
                Question = questions[num].Question
            };
        }

        public class WhiteboardViewModel
        {
            public string Question { get; set; }
        }
    }
}