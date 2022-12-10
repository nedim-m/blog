using AutoMapper;
using blog.Models.Responses;
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
    public class TagService : Service<Models.Tag, Database.Tag, BaseSearchObject, Models.Tag, MultipleTagResponse>, ITagService
    {
        public TagService(blogContext context, IMapper mapper) : base(context, mapper)
        {
        }

        


        public MultipleTagResponse GetAll()
        {
            var entityFromDb = base.Get(null);
            var entity = entityFromDb.Select(x => x.Name).Distinct().ToList();

            var objToReturn = new MultipleTagResponse();
            
            objToReturn.tags.AddRange(entity);

            return objToReturn;
        }
    }
}
