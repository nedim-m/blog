using blog.Models;
using blog.Models.Requests;
using blog.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.IServices
{
    public interface IPostService:ICrudService<Post, PostSearchObjects, PostUpsertRequest, PostUpsertRequest>
    {
        Post GetBySlug(string slug);
        Post DeleteBySlug(string slug);
        Post UpdateBySlug(string slug, PostUpsertRequest update);
    }
}
