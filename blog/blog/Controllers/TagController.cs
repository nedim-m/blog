using blog.Models;
using blog.Models.Responses;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class TagController : BaseController<Tag, BaseSearchObject, Tag, MultipleTagResponse>
    {

        public ITagService _service { get; set; }
        public TagController(ITagService service)
            : base(service)
        {
            _service = service;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Tag GetById(int id)
        {
            return base.GetById(id);
        }

        [HttpGet]
        public MultipleTagResponse GetAll()
        {
            return _service.GetAll();
        }

    }
}
