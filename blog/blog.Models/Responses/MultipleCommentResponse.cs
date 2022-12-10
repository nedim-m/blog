using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models.Responses
{
    public class MultipleCommentResponse
    {
        public IEnumerable<Comment> comments { get; set; }
    }
}
