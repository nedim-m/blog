using blog.Models;
using blog.Models.Requests;
using blog.Models.SearchObjects;
using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class CommentController : BaseCrudController<Comment,BaseSearchObject,CommentInsertRequest,CommentInsertRequest>
    {
    
        public CommentController(ICommentService service):base(service)
        {
            
        }
    }
}
