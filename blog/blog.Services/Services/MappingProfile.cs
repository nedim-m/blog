using AutoMapper;
using blog.Models;
using blog.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Post, Post>();
            CreateMap<PostInsertRequest, Database.Post>();
            CreateMap<PostUpdateRequest, Database.Post>();

            CreateMap<Database.Post, Models.Responses.SinglePostReturn>()
               .ForPath(dest => dest.blogPost.Body, opt => opt.MapFrom(src => src.Body))
               .ForPath(dest => dest.blogPost.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForPath(dest => dest.blogPost.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForPath(dest => dest.blogPost.Slug, opt => opt.MapFrom(src => src.Slug))
               .ForPath(dest => dest.blogPost.Description, opt => opt.MapFrom(src => src.Description))
               .ForPath(dest => dest.blogPost.Title, opt => opt.MapFrom(src => src.Title));






            CreateMap<Database.Tag, Tag>();


           


        }
    }
}
