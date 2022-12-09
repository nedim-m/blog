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
        public Models.Responses.SinglePostReturn GetBySlug (string slug)
        {
            return _service.GetBySlug(slug);
        }

        [HttpDelete("{slug}")]
        public Models.Responses.SinglePostReturn DeleteBySlug(string slug)
        {
            return _service.DeleteBySlug(slug);
        }


        [HttpPut("{slug}")]
        public Models.Responses.SinglePostReturn UpdateBySlug(string slug,[FromBody] PostUpdateRequest update)
        {
         return _service.UpdateBySlug(slug, update);
           
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Post GetById(int id)
        {
            return base.GetById(id);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Post Insert([FromBody] PostInsertRequest insert)
        {
            return base.Insert(insert);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Post Update(int id, [FromBody] PostUpdateRequest update)
        {
            return base.Update(id, update);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Post Delete(int id)
        {
            return base.Delete(id);
        }


    }
}
