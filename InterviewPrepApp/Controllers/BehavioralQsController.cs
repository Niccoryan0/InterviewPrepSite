using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InterviewPrepApp.Data;
using InterviewPrepApp.Models;

namespace InterviewPrepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehavioralQsController : ControllerBase
    {
        private readonly QuestionsDbContext _context;

        public BehavioralQsController(QuestionsDbContext context)
        {
            _context = context;
        }

        // GET: api/BehavioralQs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BehavioralQ>>> GetBehavioralQs()
        {
            return await _context.BehavioralQs.ToListAsync();
        }

        // GET: api/BehavioralQs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BehavioralQ>> GetBehavioralQ(int id)
        {
            var behavioralQ = await _context.BehavioralQs.FindAsync(id);

            if (behavioralQ == null)
            {
                return NotFound();
            }

            return behavioralQ;
        }

        // PUT: api/BehavioralQs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBehavioralQ(int id, BehavioralQ behavioralQ)
        {
            if (id != behavioralQ.Id)
            {
                return BadRequest();
            }

            _context.Entry(behavioralQ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BehavioralQExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BehavioralQs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BehavioralQ>> PostBehavioralQ(BehavioralQ behavioralQ)
        {
            _context.BehavioralQs.Add(behavioralQ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBehavioralQ", new { id = behavioralQ.Id }, behavioralQ);
        }

        // DELETE: api/BehavioralQs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BehavioralQ>> DeleteBehavioralQ(int id)
        {
            var behavioralQ = await _context.BehavioralQs.FindAsync(id);
            if (behavioralQ == null)
            {
                return NotFound();
            }

            _context.BehavioralQs.Remove(behavioralQ);
            await _context.SaveChangesAsync();

            return behavioralQ;
        }

        private bool BehavioralQExists(int id)
        {
            return _context.BehavioralQs.Any(e => e.Id == id);
        }
    }
}
