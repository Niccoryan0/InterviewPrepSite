﻿using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class QuizRepository : IQuiz
    {
        private QuestionsDbContext _context;

        public QuizRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all quizzes
        /// </summary>
        /// <returns>List of all quizs</returns>
        public async Task<List<Quiz>> GetQuizzes()
        {
            var quizzes = await _context.Quizzes.ToListAsync();
            return quizzes;
        }

        /// <summary>
        /// Create a new quiz
        /// </summary>
        /// <param name="quiz">Quiz to be added to database</param>
        /// <returns>Task of completion for quiz creation</returns>
        public async Task Create(Quiz quiz)
        {
            _context.Entry(quiz).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete a quiz
        /// </summary>
        /// <param name="quiz">quiz to be deleted</param>
        /// <returns>ask of completion</returns>
        public async Task Delete(int id)
        {
            Quiz quiz = await _context.Quizzes.FindAsync(id);
            if (quiz != null)
            {
                _context.Entry(quiz).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete a quiz
        /// </summary>
        /// <param name="quiz">quiz to be deleted</param>
        /// <returns>Task of completion</returns>
        public async Task Update(Quiz quiz)
        {
            _context.Entry(quiz).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
