using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch,TSingleReturn,TMultipleReturn> : ControllerBase where T:class where TSearch: class where TSingleReturn :class where TMultipleReturn:class
    {
        public IService<T, TSearch,TSingleReturn,TMultipleReturn> _service;

        public BaseController(IService<T, TSearch,TSingleReturn,TMultipleReturn> service)
        {
            _service=service;
        }


       
       
       
        [HttpGet("{id:int}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
