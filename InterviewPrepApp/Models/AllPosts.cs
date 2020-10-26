using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class AllPosts
    {
        public string Username { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
    }
}
