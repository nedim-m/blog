using blog.Models.Responses;
using blog.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.IServices
{
    public interface ITagService:IService<Models.Tag,BaseSearchObject,Models.Tag,MultipleTagResponse>
    {
        MultipleTagResponse GetAll();
    }
}
