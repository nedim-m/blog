using AutoMapper;
using blog.Models;
using blog.Models.Requests;
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
    public class PostService : CrudService<Models.Post, Database.Post, PostSearchObjects, PostUpsertRequest, PostUpsertRequest>, IPostService
    {
        public PostService(blogContext context, IMapper mapper) : base(context, mapper)
        {
        }


    }
}
