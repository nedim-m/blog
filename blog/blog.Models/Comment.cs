using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Body { get; set; }
        public int PostId { get; set; }
     
    }
}
