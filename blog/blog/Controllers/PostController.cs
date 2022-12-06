using blog.Models;
using blog.Models.Requests;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class PostController : BaseCrudController<Post, PostSearchObjects, PostUpsertRequest, PostUpsertRequest>
    {
        public IPostService _service { get; set; }

        public PostController(IPostService service):base(service)
        {
            _service=service;
        }

        
        
    }
}
