using AutoMapper;
using Azure;
using blog.Models;
using blog.Models.Requests;
using blog.Models.SearchObjects;
using blog.Services.Database;
using blog.Services.IServices;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Services
{
    public class PostService : CrudService<Models.Post, Database.Post, PostSearchObjects, PostInsertRequest, PostUpdateRequest>, IPostService
    {
        public PostService(blogContext context, IMapper mapper) : base(context, mapper)
        {
        }




        public override IEnumerable<Models.Post> Get(PostSearchObjects search = null)
        {
            var entity = base.Get(search);
           
            

            foreach(var item in entity)
            {
                item.TagList=Tags(item.Slug);
            }
            
            return entity;
        }
        public override Models.Post GetById(int id)
        {
            var entity= base.GetById(id);
            var postFromDb = _context.Set<Database.Post>();

            var slug = postFromDb.Find(id).Slug;

            entity.TagList=Tags(slug);
            return entity;
        }


        public override Models.Post Insert(PostInsertRequest insert)
        {
            var entity = base.Insert(insert);

            var postFromDb = _context.Set<Database.Post>();
            var postId = postFromDb.Where(i => i.Title==insert.Title).FirstOrDefault().PostId;

            foreach (var tagName in insert.TagList)
            {
                Database.Tag tag = new Database.Tag();
                tag.PostId=postId;
                tag.Name=tagName;

                _context.Tags.Add(tag);
            }
            _context.SaveChanges();


            return entity;

        }
        public override void BeforeInsert(PostInsertRequest insert, Database.Post entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.Slug=ConvertToSlug(insert.Title);
            base.BeforeInsert(insert, entity);
        }





        public override Models.Post Update(int id, PostUpdateRequest update)
        {
            return base.Update(id, update);
        }

        public override void BeforeUpdate(PostUpdateRequest update, Database.Post entity)
        {
            entity.UpdatedAt=DateTime.Now;
            entity.Slug=ConvertToSlug(update.Title);
            base.BeforeUpdate(update, entity);
        }
        public string ConvertToSlug(string title)
        {
            return title.ToLower().Replace(" ", "-");

        }

        public Models.Post GetBySlug(string slug)
        {

            var entity = _context.Posts.FirstOrDefault(p => p.Slug!.Equals(slug));

            if (entity!=null)
            {
                var TagList = _context.Tags.Where(x => x.PostId==entity!.PostId).ToList();

                var entityToReturn = _mapper.Map<Models.Post>(entity);
                foreach (var tag in TagList)
                {
                    entityToReturn.TagList.Add(tag.Name!);

                }
                return entityToReturn;
            }
            return null;

        }

        public Models.Post DeleteBySlug(string slug)
        {
            var set = _context.Set<Database.Post>();
            var entity = _context.Posts.FirstOrDefault(p => p.Slug!.Equals(slug));
            var entityToReturn = _mapper.Map<Models.Post>(entity);
            if (entity!=null)
            {
                set.Remove(entity);
            }
            else
            {
                return null;
            }
            _context.SaveChanges();
            return entityToReturn;
        }

        public Models.Post UpdateBySlug(string slug, PostUpdateRequest update)
        {
            var set = _context.Set<Database.Post>();
            var entity = _context.Posts.FirstOrDefault(p => p.Slug!.Equals(slug));

            if (entity != null)
            {
                _mapper.Map(update, entity);
            }
            else
            {
                return null;
            }
            BeforeUpdate(update, entity);
            _context.SaveChanges();

            return _mapper.Map<Models.Post>(entity);
        }

        public override IQueryable<Database.Post> AddFilter(IQueryable<Database.Post> query, PostSearchObjects search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            var tagsFromDb = _context.Set<Database.Tag>();



            if (!string.IsNullOrWhiteSpace(search?.TagName))
            {
                var tags = tagsFromDb.Where(t => t.Name==search.TagName);

                List<int> tagIds = new();

                foreach (var tag in tags)
                {
                    tagIds.Add(tag.PostId);
                }
                filteredQuery = filteredQuery.Where(x => tagIds.Contains(x.PostId));


            }

            return filteredQuery;
        }

    

        public List<string>Tags(string slug)
        {
            var tagsFromDb = _context.Set<Database.Tag>();
            var postFromDb = _context.Set<Database.Post>();
            var postId=postFromDb.Where(i=>i.Slug==slug).FirstOrDefault().PostId;


            var tagsToPush = tagsFromDb.Where(x => x.PostId==postId).ToList();

            List<string> tags = new();

            foreach (var tag in tagsToPush)
            {
                tags.Add(tag.Name!);
            }
            return tags;
        }
    }
}
