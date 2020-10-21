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
using Microsoft.AspNetCore.Authorization;

namespace InterviewPrepApp.Controllers
{
    [Route("api/whiteboard")]
    [ApiController]
    public class WhiteboardQsController : ControllerBase
    {
        private IWhiteboardQ _questions { get; set; }

        public WhiteboardQsController(IWhiteboardQ question)
        {
            _questions = question;
        }

        // GET: api/WhiteboardQs
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<WhiteboardQ>>> GetWhiteboardQs()
        {
            return await _questions.GetWhiteboardQs();
        }

        // GET: api/WhiteboardQs/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<WhiteboardQ>> GetWhiteboardQ(int id)
        {
            var whiteboardQ = await _questions.GetWhiteboardQ(id);

            return whiteboardQ;
        }

        // PUT: api/WhiteboardQs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWhiteboardQ(int id, WhiteboardQ whiteboardQ)
        {
            if (id != whiteboardQ.Id)
            {
                return BadRequest();
            }

            await _questions.Update(whiteboardQ);

            return NoContent();
        }

        // POST: api/WhiteboardQs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WhiteboardQ>> PostWhiteboardQ(WhiteboardQ whiteboardQ)
        {
            await _questions.Create(whiteboardQ);

            return CreatedAtAction("GetWhiteboardQ", new { id = whiteboardQ.Id }, whiteboardQ);
        }

        // DELETE: api/WhiteboardQs/5
        [HttpDelete("{id}")]
        public async Task DeleteWhiteboardQ(int id)
        {
            await _questions.Delete(id);
        }
    }
}
