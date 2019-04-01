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
                new { Id=1, Title="Sample Post Title", Author="Joe Bloggs", Post="This is a sample blog post.", PostSummary="This is a sample blog post.", Posted=DateTime.Now },
                new { Id=2, Title="Sample Post Title 2", Author="Joe Cloggs", Post="2 This is a sample blog post.", PostSummary="2 This is a sample blog post.", Posted=DateTime.Now.AddDays(-1)},
                new { Id=3, Title="Sample Post Title 3", Author="Joe Doggs", Post="3 This is a sample blog post.", PostSummary="3 This is a sample blog post.", Posted=DateTime.Now.AddDays(-2) },
                new { Id=4, Title="Sample Post Title 4", Author="Joe Eloggs", Post="4 This is a sample blog post.", PostSummary="4 This is a sample blog post.", Posted=DateTime.Now.AddDays(-3) },
                new { Id=5, Title="Sample Post Title 5", Author="Joe Floggs", Post="5 This is a sample blog post.", PostSummary="5 This is a sample blog post.", Posted=DateTime.Now.AddDays(-4) }
            );
        }
    }
}