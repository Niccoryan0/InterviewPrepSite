using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPrepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IQuiz _quiz { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;

        public QuizController(IQuiz quiz, UserManager<ApplicationUser> userManager)
        {
            _quiz = quiz;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet("{n}")]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizzes(int n)
        {
            return await _quiz.GetNRecentQuizzes(n);
        }

        [HttpPost]
        public async Task<ActionResult<Quiz>> PostQuiz(Quiz quiz)
        {
            string username = User.Identity.Name.ToString();
            ApplicationUser user = await _userManager.FindByNameAsync(username);

            quiz.CreatedDate = DateTime.Now;
            quiz.UpdatedDate = DateTime.Now;
            quiz.Username = user.UserName;
            quiz.Avatar = user.Avatar;
            quiz.Upvotes = 0;
            quiz.Downvotes = 0;


            await _quiz.Create(quiz);

            return CreatedAtAction("GetBehavioralQ", new { id = quiz.Id }, quiz);
        }

    }
}
