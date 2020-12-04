using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Avatar { get; set; }
        public string Level { get; set; }

    }

    public static class ApplicationRoles
    {
        public const string Nicco = "Nicco";
        public const string Admin = "Admin";
        public const string Contributor = "Contributor";
    }
}
