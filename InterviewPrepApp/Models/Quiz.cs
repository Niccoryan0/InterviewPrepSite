using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class Quiz : AllPosts
    {
        public int Id { get; set; }
        public string technical1q { get; set; }
        public string technical1a { get; set; }
        public string technical2q { get; set; }
        public string technical2a { get; set; }
        public string technical3q { get; set; }
        public string technical3a { get; set; }
        public string whiteboard1q { get; set; }
        public string whiteboard1a { get; set; }
        public string whiteboard2q { get; set; }
        public string whiteboard2a { get; set; }
        public List<ForumComment> Comments { get; set; }
    }
}
