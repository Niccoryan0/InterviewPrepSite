using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPrepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IQuiz _quiz { get; set; }

        public QuizController(IQuiz quiz)
        {
            _quiz = quiz;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizzes()
        {
            return await _quiz.GetQuizzes();
        }

        [HttpPost]
        public async Task<ActionResult<Quiz>> PostQuiz(Quiz quiz)
        {
            await _quiz.Create(quiz);

            return CreatedAtAction("GetBehavioralQ", new { id = quiz.Id }, quiz);
        }
    }
}
