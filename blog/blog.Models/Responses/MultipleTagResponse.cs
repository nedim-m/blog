using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Models.Responses
{
    public class MultipleTagResponse
    {
        public List<string> tags { get; set; } = new List<string> { };

    }
}
