using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class BehavioralQRepository : IBehavioralQ
    {
        private QuestionsDbContext _context;

        public BehavioralQRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        public async Task<BehavioralQ> GetBehavioralQ(int id)
        {
            var questions = await _context.BehavioralQs.FindAsync(id);
            return questions;
        }

        public async Task<List<BehavioralQ>> GetBehavioralQs()
        {
            var questions = await _context.BehavioralQs.ToListAsync();
            return questions;
        }

        public async Task Create(BehavioralQ question)
        {
            _context.Entry(question).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
}
