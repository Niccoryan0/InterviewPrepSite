﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Questions
{
    public class TraversalsModel : PageModel
    {
        private ITraversal _questions;
        public List<int> NumbersUsed { get; set; }

        public TraversalsViewModel Question { get; set; }

        public TraversalsModel(ITraversal questions)
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
            var questions = await _questions.GetTraversals();
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
            Question = new TraversalsViewModel()
            {
                Question = questions[num].Question,
                Category = questions[num].Category
            };
        }
    }
}