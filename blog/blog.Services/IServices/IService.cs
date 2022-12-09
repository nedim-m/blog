using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.IServices
{
    public interface IService<T,TSearch, TSingleReturn, TMultipleReturn> where T:class where TSearch:class
    {
        public IEnumerable<T> Get(TSearch search = null);
        T GetById(int id);
    }
}
