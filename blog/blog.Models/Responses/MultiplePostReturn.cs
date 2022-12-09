using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models.Responses
{
    public class MultiplePostReturn
    {
        public List<Post> blogPosts { get; set; }
        public int postsCount { get; set; }
    }
}
