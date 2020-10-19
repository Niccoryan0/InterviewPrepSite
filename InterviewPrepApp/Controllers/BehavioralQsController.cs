using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InterviewPrepApp.Data;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;

namespace InterviewPrepApp.Controllers
{
    [Route("api/behavioral")]
    [ApiController]
    public class BehavioralQsController : ControllerBase
    {
        private IBehavioralQ _questions { get; set; }

        public BehavioralQsController(IBehavioralQ question)
        {
            _questions = question;
        }

        // GET: api/BehavioralQs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BehavioralQ>>> GetBehavioralQs()
        {
            return await _questions.GetBehavioralQs();
        }

        // GET: api/BehavioralQs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BehavioralQ>> GetBehavioralQ(int id)
        {
            var behavioralQ = await _questions.GetBehavioralQ(id);

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

            await _questions.Update(behavioralQ);

            return NoContent();
        }

        // POST: api/BehavioralQs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BehavioralQ>> PostBehavioralQ(BehavioralQ behavioralQ)
        {
            await _questions.Create(behavioralQ);

            return CreatedAtAction("GetBehavioralQ", new { id = behavioralQ.Id }, behavioralQ);
        }

        // DELETE: api/BehavioralQs/5
        [HttpDelete("{id}")]
        public async Task DeleteBehavioralQ(int id)
        {
            await _questions.Delete(id);
        }
    }
}
