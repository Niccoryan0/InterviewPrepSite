using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard
{
    public class TraversalsModel : PageModel
    {
        public ITraversal _questions { get; set; }
        public List<TraversalQ> AllQs { get; set; }
        [BindProperty]
        public TraversalsViewModel Question { get; set; }

        public TraversalsModel(ITraversal questions)
        {
            _questions = questions;
        }


        public async Task OnGet()
        {
            AllQs = await _questions.GetTraversals();
        }

        public async Task<IActionResult> OnPost()
        {
            TraversalQ question = new TraversalQ
            {
                Question = Question.Question,
                Category = Question.Category
            };
            await _questions.Create(question);
            AllQs = await _questions.GetTraversals();
            return Page();
        }
    }
}