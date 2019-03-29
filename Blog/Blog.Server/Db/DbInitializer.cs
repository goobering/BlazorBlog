using Blog.Shared;
using System.Text;
using System.Linq;
using System;

namespace Blog.Server
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            if(context.BlogPosts.Any())
            {
                return;
            }

            for(int i = 0; i < 10; i++)
            {
                var seedBlogPost = new BlogPost{
                    Title = string.Format("Sample Post Title {0}", i.ToString()),
                    Author = string.Format("Joe Bloggs {0}", i.ToString()),
                    Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Posted = DateTime.Now.AddDays(i)
                };

                context.BlogPosts.Add(seedBlogPost);
                context.SaveChanges();
            }
            

        }
    }
}