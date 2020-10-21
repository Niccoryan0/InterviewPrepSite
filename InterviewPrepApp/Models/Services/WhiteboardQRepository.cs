using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class WhiteboardQRepository : IWhiteboardQ
    {
        private QuestionsDbContext _context;

        public WhiteboardQRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        public async Task<WhiteboardQ> GetWhiteboardQ(int id)
        {
            var questions = await _context.WhiteboardQs.FindAsync(id);
            return questions;
        }

        public async Task<List<WhiteboardQ>> GetWhiteboardQs()
        {
            var questions = await _context.WhiteboardQs.ToListAsync();
            return questions;
        }

        public async Task Create(WhiteboardQ question)
        {
            _context.Entry(question).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            WhiteboardQ question = await _context.WhiteboardQs.FindAsync(id);
            if (question != null)
            {
                _context.Entry(question).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(WhiteboardQ question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
