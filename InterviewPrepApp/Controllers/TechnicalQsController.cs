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
    [Route("api/technical")]
    [ApiController]
    public class TechnicalQsController : ControllerBase
    {
        private ITechnicalQ _questions { get; set; }

        public TechnicalQsController(ITechnicalQ question)
        {
            _questions = question;
        }

        // GET: api/Technical
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TechnicalQ>>> GetTechnicalQs()
        {
            return await _questions.GetTechnicalQs();
        }

        // GET: api/TechnicalQs/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<TechnicalQ>> GetTechnicalQ(int id)
        {
            var technicalQ = await _questions.GetTechnicalQ(id);

            return technicalQ;
        }

        // PUT: api/TechnicalQs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechnicalQ(int id, TechnicalQ technicalQ)
        {
            if (id != technicalQ.Id)
            {
                return BadRequest();
            }

            await _questions.Update(technicalQ);

            return NoContent();
        }

        // POST: api/TechnicalQs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TechnicalQ>> PostTechnicalQ(TechnicalQ technicalQ)
        {
            await _questions.Create(technicalQ);

            return CreatedAtAction("GetTechnicalQ", new { id = technicalQ.Id }, technicalQ);
        }

        // DELETE: api/TechnicalQs/5
        [HttpDelete("{id}")]
        public async Task DeleteTechnicalQ(int id)
        {
            await _questions.Delete(id);
        }
    }
}
