using blog.Models;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class TagController : BaseController<Tag, BaseSearchObject>
    {
       

        public TagController(IService<Tag, BaseSearchObject> service)
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
