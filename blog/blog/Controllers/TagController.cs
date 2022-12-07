using blog.Models;
using blog.Models.SearchObjects;
using blog.Services.IServices;


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
