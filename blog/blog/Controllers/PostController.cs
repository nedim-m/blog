using blog.Models;
using blog.Models.Requests;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using blog.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class PostController : BaseCrudController<Post, PostSearchObjects, PostInsertRequest, PostUpdateRequest>
    {
        public IPostService _service { get; set; }

        public PostController(IPostService service):base(service)
        {
            _service=service;
        }





        [HttpGet("{slug}")]
        public Post GetBySlug (string slug)
        {
            return _service.GetBySlug(slug);
        }

        [HttpDelete("{slug}")]
        public Post DeleteBySlug(string slug)
        {
            return _service.DeleteBySlug(slug);
        }


        [HttpPut("{slug}")]
        public Post UpdateBySlug(string slug,[FromBody] PostUpdateRequest update)
        {
         return _service.UpdateBySlug(slug, update);
           
        }

    }
}
