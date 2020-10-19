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
    [Route("api/traversals")]
    [ApiController]
    public class TraversalQsController : ControllerBase
    {
        private ITraversal _questions { get; set; }

        public TraversalQsController(ITraversal question)
        {
            _questions = question;
        }

        // GET: api/TraversalQs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TraversalQ>>> GetTraversalQs()
        {
            return await _questions.GetTraversals();
        }

        // GET: api/TraversalQs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TraversalQ>> GetTraversalQ(int id)
        {
            var traversalQ = await _questions.GetTraversal(id);

            return traversalQ;
        }

        // PUT: api/TraversalQs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTraversalQ(int id, TraversalQ traversalQ)
        {
            if (id != traversalQ.Id)
            {
                return BadRequest();
            }

            await _questions.Update(traversalQ);

            return NoContent();
        }

        // POST: api/TraversalQs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TraversalQ>> PostTraversalQ(TraversalQ traversalQ)
        {
            await _questions.Create(traversalQ);

            return CreatedAtAction("GetTraversalQ", new { id = traversalQ.Id }, traversalQ);
        }

        // DELETE: api/TraversalQs/5
        [HttpDelete("{id}")]
        public async Task DeleteTraversalQ(int id)
        {
            await _questions.Delete(id);
        }
    }
}
