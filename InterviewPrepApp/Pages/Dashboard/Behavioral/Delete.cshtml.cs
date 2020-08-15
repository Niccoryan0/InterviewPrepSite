using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepApp.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewPrepApp.Pages.Dashboard.Behavioral
{
    public class DeleteModel : PageModel
    {
        public IBehavioralQ _questions { get; set; }

        public DeleteModel(IBehavioralQ questions)
        {
            _questions = questions;
        }
        public void OnGet()
        {

        }

    }
}