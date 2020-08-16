using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface IWhiteboardQ
    {
        /// <summary>
        /// Get all whiteboard questions
        /// </summary>
        /// <returns>List of all whiteboard questions</returns>
        Task<List<WhiteboardQ>> GetWhiteboardQs();

        /// <summary>
        /// Get a specific whiteboard question
        /// </summary>
        /// <param name="id">Unique id of question to be retrieved</param>
        /// <returns>Successful completion of whiteboard question retrieval</returns>
        Task<WhiteboardQ> GetWhiteboardQ(int id);

        /// <summary>
        /// Create a new whiteboard question
        /// </summary>
        /// <param name="question">Question to be added to database</param>
        /// <returns>Task of completion for question creation</returns>
        Task Create(WhiteboardQ question);

        /// <summary>
        /// Delete a whiteboard question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Delete(int id);

        /// <summary>
        /// Delete a whiteboard question
        /// </summary>
        /// <param name="question">Question to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Update(WhiteboardQ question);
    }
}
