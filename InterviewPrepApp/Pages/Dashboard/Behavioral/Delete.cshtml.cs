using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models.Interface;
using InterviewPrepApp.Pages.Questions.Dashboard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Behavioral
{
    [Authorize(Policy = "NiccoOnly")]
    public class DeleteModel : PageModel
    {
        public IBehavioralQ _questions { get; set; }
        [BindProperty]
        public DeleteViewModel Question { get; set; }

        public DeleteModel(IBehavioralQ questions)
        {
            _questions = questions;
            Question = new DeleteViewModel();
        }

        public async Task OnGet(int id)
        {
            var question = await _questions.GetBehavioralQ(id);
            Question.Id = question.Id;
            Question.Question = question.Question;
        }

        public async Task<IActionResult> OnPost()
        {
            await _questions.Delete(Question.Id);
            return RedirectToPage("/Dashboard/Behavioral");
        }


    }
    public class DeleteViewModel
    {
        public string Question { get; set; }
        public int Id { get; set; }
    }
}