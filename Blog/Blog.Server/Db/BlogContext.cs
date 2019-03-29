using Microsoft.EntityFrameworkCore;
using Blog.Shared;
using System;

namespace Blog.Server
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>().ToTable("BlogPosts");

            modelBuilder.Entity<BlogPost>().HasData(
                new { Id=1, Title="Sample Post Title", Author="Joe Bloggs", Post="This is a sample blog post.", PostSummary="This is a sample blog post.", Posted=DateTime.Now }
            );
        }
    }
}