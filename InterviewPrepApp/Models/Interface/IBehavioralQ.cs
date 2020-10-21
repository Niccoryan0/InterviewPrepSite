using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface IBehavioralQ
    {
        /// <summary>
        /// Get all behavioral questions
        /// </summary>
        /// <returns>List of all behavioral questions</returns>
        Task<List<BehavioralQ>> GetBehavioralQs();

        /// <summary>
        /// Get a specific behavioral question
        /// </summary>
        /// <param name="id">Unique id of question to be retrieved</param>
        /// <returns>Successful completion of behavioral question retrieval</returns>
        Task<BehavioralQ> GetBehavioralQ(int id);

        /// <summary>
        /// Create a new behavioral question
        /// </summary>
        /// <param name="question">Question to be added to database</param>
        /// <returns>Task of completion for question creation</returns>
        Task Create(BehavioralQ question);

        /// <summary>
        /// Delete a behavioral question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Delete(int id);

        /// <summary>
        /// Delete a behavioral question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Update(BehavioralQ question);
    }
}
