using blog.Models;
using blog.Models.Responses;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class TagController : BaseController<Tag, BaseSearchObject, Tag, MultipleTagResponse>
    {
       

        public TagController(IService<Tag, BaseSearchObject, Tag, MultipleTagResponse> service)
            : base(service)
        {
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Tag GetById(int id)
        {
            return base.GetById(id);
        }

    }
}
