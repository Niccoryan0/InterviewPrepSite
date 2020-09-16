using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface ITraversal
    {
        /// <summary>
        /// Get all technical questions
        /// </summary>
        /// <returns>List of all technical questions</returns>
        Task<List<TraversalQ>> GetTraversals();

        /// <summary>
        /// Get a specific technical question
        /// </summary>
        /// <param name="id">Unique id of question to be retrieved</param>
        /// <returns>Successful completion of technical question retrieval</returns>
        Task<TraversalQ> GetTraversal(int id);

        /// <summary>
        /// Create a new technical question
        /// </summary>
        /// <param name="question">Question to be added to database</param>
        /// <returns>Task of completion for question creation</returns>
        Task Create(TraversalQ traversal);

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
        Task Update(TraversalQ traversal);
    }
}
