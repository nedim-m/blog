using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch> : ControllerBase where T:class where TSearch: class
    {
        public IService<T, TSearch> _service;

        public BaseController(IService<T, TSearch> service)
        {
            _service=service;
        }

        [HttpGet]
        public IEnumerable<T> Get([FromQuery] TSearch search = null)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
