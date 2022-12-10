using blog.Models;
using blog.Models.Requests;
using blog.Models.Responses;
using blog.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.IServices
{
    public interface IPostService:ICrudService<Post, PostSearchObjects, PostInsertRequest,PostUpdateRequest,SinglePostReturn,MultiplePostReturn>
    {
        SinglePostReturn GetBySlug(string slug);
        SinglePostReturn DeleteBySlug(string slug);
        SinglePostReturn UpdateBySlug(string slug, PostUpdateRequest update);
        MultiplePostReturn GetAll(PostSearchObjects search = null);
    }
}
