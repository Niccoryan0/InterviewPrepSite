using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Models
{
    public class ForumComment : AllPosts
    {
        public int Id { get; set; }
        [Required]
        public int QuizId { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
