using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    interface IQuiz
    {
        /// <summary>
        /// Get all quizzes
        /// </summary>
        /// <returns>List of all quizs</returns>
        Task<List<Quiz>> GetQuizzes();

        /// <summary>
        /// Create a new quiz
        /// </summary>
        /// <param name="quiz">Quiz to be added to database</param>
        /// <returns>Task of completion for quiz creation</returns>
        Task Create(Quiz quiz);

        /// <summary>
        /// Delete a quiz
        /// </summary>
        /// <param name="quiz">quiz to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Delete(int id);

        /// <summary>
        /// Delete a quiz
        /// </summary>
        /// <param name="quiz">quiz to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Update(Quiz quiz);
    }
}
