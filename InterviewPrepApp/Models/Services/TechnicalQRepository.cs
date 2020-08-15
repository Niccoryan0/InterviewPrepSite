using InterviewPrepApp.Data;
using InterviewPrepApp.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models.Services
{
    public class TechnicalQRepository : ITechnicalQ
    {
        private QuestionsDbContext _context;

        public TechnicalQRepository(QuestionsDbContext context)
        {
            _context = context;
        }

        public async Task<TechnicalQ> GetTechnicalQ(int id)
        {
            var questions = await _context.TechnicalQs.FindAsync(id);
            return questions;
        }

        public async Task<List<TechnicalQ>> GetTechnicalQs()
        {
            var questions = await _context.TechnicalQs.ToListAsync();
            return questions;
        }

        public async Task Create(TechnicalQ question)
        {
            _context.Entry(question).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
}
