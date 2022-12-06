using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models.Requests
{
    public class PostUpsertRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
    }
}
