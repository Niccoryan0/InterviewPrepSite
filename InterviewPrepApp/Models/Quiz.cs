using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class Quiz : AllPosts
    {
        public int Id { get; set; }
        public string technical1 { get; set; }
        public string technical2 { get; set; }
        public string technical3 { get; set; }
        public string whiteboard1 { get; set; }
        public string whiteboard2 { get; set; }
        public List<ForumComment> Comments
    }
}
