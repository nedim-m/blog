﻿using blog.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace blog.Controllers
{
    
    public class BaseCrudController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public BaseCrudController(ICrudService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
        }

        
        [HttpPost]
        public virtual T Insert([FromBody] TInsert insert)
        {
            var result = ((ICrudService<T, TSearch, TInsert, TUpdate>)this._service).Insert(insert);

            return result;
        }
       
        [HttpPut]
        public virtual T Update(int id, [FromBody] TUpdate update)
        {
            var result = ((ICrudService<T, TSearch, TInsert, TUpdate>)this._service).Update(id, update);
            return result;
        }


        [HttpDelete]
        public virtual T Delete(int id)
        {
            var result = ((ICrudService<T, TSearch, TInsert, TUpdate>)this._service).Delete(id);
            return result;
        }
    }
}
