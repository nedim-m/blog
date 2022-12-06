using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Services.Database
{
    public class blogContext : DbContext
    {
        public blogContext(DbContextOptions<blogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }


    }
}
