using System.Collections.Generic;
using System.Linq;
using Blog.Shared;

namespace Blog.Server
{
    public class BlogPostManager : IDataRepository<BlogPost>
    {
        readonly BlogContext _blogcontext;

        public BlogPostManager(BlogContext context)
        {
            _blogcontext = context;
        }

        public IEnumerable<BlogPost> GetAll()
        {
            return _blogcontext.BlogPosts.ToList();
        }

        public BlogPost Get(int id)
        {
            return _blogcontext.BlogPosts
                .FirstOrDefault(p => p.Id == id);
        }

        public void Add(BlogPost post)
        {
            _blogcontext.BlogPosts.Add(post);
            _blogcontext.SaveChanges();
        }

        public void Update(BlogPost post, BlogPost entity)
        {
            post.Title = entity.Title;
            post.Author = entity.Author;
            post.Post = entity.Post;
            post.Posted = entity.Posted;

            _blogcontext.SaveChanges();
        }

        public void Delete(BlogPost post)
        {
            _blogcontext.BlogPosts.Remove(post);
            _blogcontext.SaveChanges();
        }
    }
}