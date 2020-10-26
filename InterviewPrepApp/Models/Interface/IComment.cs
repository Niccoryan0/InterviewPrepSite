using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Interface
{
    public interface IComment
    {
        /// <summary>
        /// Get all comments
        /// </summary>
        /// <returns>List of all comments</returns>
        Task<List<ForumComment>> GetComments();

        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="comment">ForumComment to be added to database</param>
        /// <returns>Task of completion for comment creation</returns>
        Task Create(ForumComment comment);

        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="comment">comment to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Delete(int id);

        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="comment">comment to be deleted</param>
        /// <returns>Task of completion</returns>
        Task Update(ForumComment comment);
    }
}
