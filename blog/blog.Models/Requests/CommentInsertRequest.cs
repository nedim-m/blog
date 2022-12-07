using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models.Requests
{
    public class CommentInsertRequest
    {
        [Required]
        public string? Body { get; set; }
    }
}
