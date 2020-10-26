using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class CommentRepository : IComment
    {
        private QuestionsDbContext _context;

        public CommentRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all comments
        /// </summary>
        /// <returns>List of all comments</returns>
        public async Task<List<ForumComment>> GetComments()
        {
            var comments = await _context.ForumComments.ToListAsync();
            return comments;
        }

        /// <summary>
        /// Create a new comment
        /// </summary>
        /// <param name="comment">ForumComment to be added to database</param>
        /// <returns>Task of completion for comment creation</returns>
        public async Task Create(ForumComment comment)
        {
            _context.Entry(comment).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="comment">comment to be deleted</param>
        /// <returns>ask of completion</returns>
        public async Task Delete(int id)
        {
            ForumComment comment = await _context.ForumComments.FindAsync(id);
            if (comment != null)
            {
                _context.Entry(comment).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="comment">comment to be deleted</param>
        /// <returns>Task of completion</returns>
        public async Task Update(ForumComment comment)
        {
            _context.Entry(comment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
