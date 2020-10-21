using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface ITechnicalQ
    {
        /// <summary>
        /// Get all technical questions
        /// </summary>
        /// <returns>List of all technical questions</returns>
        Task<List<TechnicalQ>> GetTechnicalQs();

        /// <summary>
        /// Get a specific technical question
        /// </summary>
        /// <param name="id">Unique id of question to be retrieved</param>
        /// <returns>Successful completion of technical question retrieval</returns>
        Task<TechnicalQ> GetTechnicalQ(int id);

        /// <summary>
        /// Create a new technical question
        /// </summary>
        /// <param name="question">Question to be added to database</param>
        /// <returns>Task of completion for question creation</returns>
        Task Create(TechnicalQ question);

        /// <summary>
        /// Delete a technical question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Delete(int id);     
        
        /// <summary>
        /// Delete a technical question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Update(TechnicalQ question);
    }
}