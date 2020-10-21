using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Traversal
{
    [Authorize(Policy = "NiccoOnly")]
    public class UpdateModel : PageModel
    {
        public ITraversal _questions { get; set; }
        [BindProperty]
        public UpdateViewModel Question { get; set; }

        public UpdateModel(ITraversal questions)
        {
            _questions = questions;
            Question = new UpdateViewModel();
        }

        public async Task OnGet(int id)
        {
            var question = await _questions.GetTraversal(id);
            Question.Id = question.Id;
            Question.Question = question.Question;
            Question.Category = question.Category;
        }

        public async Task<IActionResult> OnPost(int id)
        {
            TraversalQ update = new TraversalQ
            {
                Id = id,
                Question = Question.Question,
                Category = Question.Category
            };
            await _questions.Update(update);
            return RedirectToPage("/Dashboard/Behavioral");
        }

        public class UpdateViewModel
        {
            public string Question { get; set; }
            public string Category { get; set; }
            public int Id { get; set; }
        }

    }
}