using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.IServices
{
    public interface ICrudService<T,TSearch,TInsert,TUpdate, TSingleReturn,TMultipleReturn>:IService<T,TSearch, TSingleReturn, TMultipleReturn> where T : class where TSearch: class where TInsert : class where TUpdate : class where TSingleReturn :class where TMultipleReturn:class
    {
        T Insert(TInsert insert);
        T Update(int id, TUpdate update);
        T Delete(int id);
    }
}
