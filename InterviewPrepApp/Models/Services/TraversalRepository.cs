using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class TraversalRepository : ITraversal
    {
        private QuestionsDbContext _context;

        public TraversalRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        public async Task<TraversalQ> GetTraversal(int id)
        {
            var questions = await _context.Traversals.FindAsync(id);
            return questions;
        }

        public async Task<List<TraversalQ>> GetTraversals()
        {
            var questions = await _context.Traversals.ToListAsync();
            return questions;
        }

        public async Task Create(TraversalQ question)
        {
            _context.Entry(question).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            TraversalQ question = await _context.Traversals.FindAsync(id);
            if (question != null)
            {
                _context.Entry(question).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(TraversalQ question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
