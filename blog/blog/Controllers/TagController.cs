﻿using blog.Models;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class TagController : BaseController<Tag, BaseSearchObject>
    {
       

        public TagController(IService<Tag, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
