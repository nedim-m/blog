using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Database
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Body { get; set; }
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }


    }
}
