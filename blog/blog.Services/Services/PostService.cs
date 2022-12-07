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


     


        public override Models.Post Insert(PostUpsertRequest insert)
        {
           
            return base.Insert(insert);
    
        }
        public override void BeforeInsert(PostUpsertRequest insert, Database.Post entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.Slug=ConvertToSlug(insert.Title);
            base.BeforeInsert(insert, entity);
        }

    

       

        public override Models.Post Update(int id, PostUpsertRequest update)
        {
            return base.Update(id, update);
        }

        public override void BeforeUpdate(PostUpsertRequest update, Database.Post entity)
        {       
            entity.UpdatedAt=DateTime.Now;
            entity.Slug=ConvertToSlug(update.Title);
            base.BeforeUpdate(update, entity);
        }
        public string ConvertToSlug(string title)
        {
            return title.ToLower().Replace(" ", "-");

        }

    }
}
