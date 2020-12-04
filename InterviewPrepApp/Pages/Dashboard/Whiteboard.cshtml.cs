using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard
{
    [Authorize(Policy = "Users")]
    public class WhiteboardModel : PageModel
    {
        public IWhiteboardQ _questions { get; set; }
        public List<WhiteboardQ> AllQs { get; set; }
        [BindProperty]
        public WhiteboardViewModel Question { get; set; }

        public WhiteboardModel(IWhiteboardQ questions)
        {
            _questions = questions;
        }

        public async Task<IActionResult> OnGet()
        {
            AllQs = await _questions.GetWhiteboardQs();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            WhiteboardQ question = new WhiteboardQ
            {
                Question = Question.Question
            };
            await _questions.Create(question);
            AllQs = await _questions.GetWhiteboardQs();
            return Page();
        }

        public class WhiteboardViewModel
        {
            public string Question { get; set; }
        }

    }
}