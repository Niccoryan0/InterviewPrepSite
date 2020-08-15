using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Technical
{
    [Authorize(Policy = "NiccoOnly")]
    public class UpdateModel : PageModel
    {
        public ITechnicalQ _questions { get; set; }
        [BindProperty]
        public UpdateViewModel Question { get; set; }

        public UpdateModel(ITechnicalQ questions)
        {
            _questions = questions;
            Question = new UpdateViewModel();
        }

        public async Task OnGet(int id)
        {
            var question = await _questions.GetTechnicalQ(id);
            Question.Id = question.Id;
            Question.Question = question.Question;
            Question.Answer = question.Answer;
            Question.Category = question.Category;
        }

        public async Task<IActionResult> OnPost(int id)
        {
            TechnicalQ update = new TechnicalQ
            {
                Id = id,
                Question = Question.Question,
                Answer = Question.Answer,
                Category = Question.Category
            };
            await _questions.Update(update);
            return RedirectToPage("/Dashboard/Technical");
        }

        public class UpdateViewModel
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public string Category { get; set; }
            public int Id { get; set; }
        }

    }
}