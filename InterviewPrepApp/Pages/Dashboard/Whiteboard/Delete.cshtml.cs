using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models.Interface;
using InterviewPrepApp.Pages.Questions.Dashboard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Whiteboard
{
    [Authorize(Policy = "NiccoOnly")]
    public class DeleteModel : PageModel
    {
        public IWhiteboardQ _questions { get; set; }
        [BindProperty]
        public DeleteViewModel Question { get; set; }

        public DeleteModel(IWhiteboardQ questions)
        {
            _questions = questions;
            Question = new DeleteViewModel();
        }

        public async Task OnGet(int id)
        {
            var question = await _questions.GetWhiteboardQ(id);
            Question.Id = question.Id;
            Question.Question = question.Question;
        }

        public async Task<IActionResult> OnPost()
        {
            await _questions.Delete(Question.Id);
            return RedirectToPage("/Dashboard/Whiteboard");
        }


    }
    public class DeleteViewModel
    {
        public string Question { get; set; }
        public int Id { get; set; }
    }
}