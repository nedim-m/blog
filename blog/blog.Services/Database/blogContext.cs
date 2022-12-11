using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
        public blogContext()
        {

        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId=1,
                Body="This is body",
                CreatedAt=new DateTime(),
                UpdatedAt=new DateTime(),
                Title="This is title",
                Slug="this-is-title",
                Description="This is description"
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId=2,
                Body="This is body2",
                CreatedAt=new DateTime(),
                UpdatedAt=new DateTime(),
                Title="This is title2",
                Slug="this-is-title2",
                Description="This is description2"
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                PostId=3,
                Body="This is body3",
                CreatedAt=new DateTime(),
                UpdatedAt=new DateTime(),
                Title="This is title3",
                Slug="this-is-title3",
                Description="This is description3"
            });

            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=1, Name="iOS", PostId=1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=2, Name="AR", PostId=1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=3, Name="Tag", PostId=1 });

            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=4, Name="IT", PostId=2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=5, Name="OFF", PostId=2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=6, Name="Tag", PostId=2 });


            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=7, Name="iOS", PostId=3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=8, Name="UFC", PostId=3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=9, Name="Tag", PostId=3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=10, Name="IT", PostId=3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=11, Name="OFF", PostId=3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId=12, Name="OFC", PostId=3 });

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                CommentId=1,
                Body="This is a nice comment",
                PostId=3,
                CreatedAt=new DateTime(),
                UpdatedAt=new DateTime()
            });

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                CommentId=2,
                Body="This is a nice comment1",
                PostId=3,
                CreatedAt=new DateTime(),
                UpdatedAt=new DateTime()
            });
        }

    }
}
