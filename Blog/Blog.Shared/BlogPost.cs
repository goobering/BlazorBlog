using System;

namespace Blog.Shared
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Post { get; set; }
        public string PostSummary
        {
            get
            {
                if(Post.Length < 50)
                    return Post;
                else
                    return Post.Substring(0, 50);
            }
        }
        public DateTime Posted { get; set; }
        public string ImageUrl { get; set; }
    }
}