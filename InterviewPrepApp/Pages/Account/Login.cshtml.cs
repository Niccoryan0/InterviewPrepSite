using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private SignInManager<ApplicationUser> _signInManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public LoginViewModel Input { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, Input.Persistent, false);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Index");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
            }
            else
            {
                ModelState.AddModelError("", "Invalid attempt.");

            }
            return Page();
        }

        public class LoginViewModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            public bool Persistent { get; set; }
        }
    }
}