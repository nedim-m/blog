using Microsoft.VisualStudio.TestTools.UnitTesting;
using blog.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blog.Models.Responses;
using blog.Services.IServices;

namespace blog.Services.Services.Tests
{
    [TestClass()]
    public class PostServiceTests
    {
        IPostService _service;

        public PostServiceTests(IPostService service)
        {
            _service=service;
        }


        [TestMethod()]
        public void GetBySlugTest()
        {
            var objToTest = new SinglePostReturn
            {
                blogPost=new Models.Post
                {
                    Title="Title",
                    Slug="title",
                    Body="body",
                    Description="description",
                    CreatedAt=DateTime.Now,
                    UpdatedAt=DateTime.Now,

                }
            };

            var result = _service.GetBySlug("title");

            Assert.IsNull(result);


        }

        [TestMethod()]
        public void ConvertToSlugTest()
        {
            Assert.Fail();
        }
    }
}