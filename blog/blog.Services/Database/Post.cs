using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Database
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string? Slug { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    

    }
}
