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
            CreateMap<PostUpsertRequest, Database.Post>();
            

        }
    }
}
