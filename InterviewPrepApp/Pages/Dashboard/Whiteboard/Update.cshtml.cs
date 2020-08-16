using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Whiteboard
{
    [Authorize(Policy = "NiccoOnly")]
    public class UpdateModel : PageModel
    {
        public IWhiteboardQ _questions { get; set; }
        [BindProperty]
        public UpdateViewModel Question { get; set; }

        public UpdateModel(IWhiteboardQ questions)
        {
            _questions = questions;
            Question = new UpdateViewModel();
        }

        public async Task OnGet(int id)
        {
            var question = await _questions.GetWhiteboardQ(id);
            Question.Id = question.Id;
            Question.Question = question.Question;
        }

        public async Task<IActionResult> OnPost(int id)
        {
            WhiteboardQ update = new WhiteboardQ
            {
                Id = id,
                Question = Question.Question

            };
            await _questions.Update(update);
            return RedirectToPage("/Dashboard/Whiteboard");
        }

        public class UpdateViewModel
        {
            public string Question { get; set; }
            public int Id { get; set; }
        }

    }
}