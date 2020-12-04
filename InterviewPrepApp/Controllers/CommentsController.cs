using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPrepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private IComment _comment { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentsController(IComment comment, UserManager<ApplicationUser> userManager)
        {
            _comment = comment;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<ActionResult<ForumComment>> PostComment(ForumComment comment)
        {
            string username = User.Identity.Name.ToString();
            ApplicationUser user = await _userManager.FindByNameAsync(username);

            comment.CreatedDate = DateTime.Now;
            comment.UpdatedDate = DateTime.Now;
            comment.Username = user.UserName;
            comment.Avatar = user.Avatar;
            comment.Upvotes = 0;
            comment.Downvotes = 0;

            await _comment.Create(comment);

            return CreatedAtAction("GetBehavioralQ", new { id = comment.Id }, comment);
        }

        [HttpPut]
        public async Task<ActionResult<ForumComment>> PutComment(ForumComment comment)
        {
            comment.UpdatedDate = DateTime.Now;

            await _comment.Update(comment);

            return NoContent();
        }

    }
}