using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard
{
    [Authorize(Policy = "Admins")]
    public class RolesModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RolesModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        [Required]
        public string Username { get; set; }        
        [BindProperty]
        [Required]
        public bool Admin { get; set; }



        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.FindByNameAsync(Username);

            if(user == null)
            {
                ModelState.AddModelError("", "That username could not be found.");
                return Page();
            }

            if (Admin)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            } 
            else
            {
                await _userManager.AddToRoleAsync(user, "Contributor");
            }

            return RedirectToPage("/Index");
        }
    }
}