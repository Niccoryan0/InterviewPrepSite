using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface IQuiz
    {
        /// <summary>
        /// Get all quizzes
        /// </summary>
        /// <returns>List of all quizzes</returns>
        Task<List<Quiz>> GetQuizzes();

        /// <summary>
        /// Get n number of the most recent quizzes
        /// </summary>
        /// <param name="n">Number of quizzes</param>
        /// <returns>List of n most recent quizzes</returns>
        Task<List<Quiz>> GetNRecentQuizzes(int n);

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
