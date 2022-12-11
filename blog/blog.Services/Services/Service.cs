using AutoMapper;
using blog.Models.SearchObjects;
using blog.Services.Database;
using blog.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Services
{
    public class Service<T, TDb, TSearch, TSingleReturn,TMultipleReturn> : IService<T, TSearch,TSingleReturn, TMultipleReturn> where T : class where TDb : class where TSearch : BaseSearchObject where TSingleReturn:class where TMultipleReturn:class
    {

        public blogContext _context;
        public IMapper _mapper;

        public Service(blogContext context, IMapper mapper)
        {
            _context=context;
            _mapper=mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = _context.Set<TDb>().AsQueryable();
          
            entity = AddFilter(entity, search);

           
            var list = entity.ToList();

            return _mapper.Map<IList<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _context.Set<TDb>();
            var entitiy = set.Find(id);

            return _mapper.Map<T>(entitiy);
        }




        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

    }
}
