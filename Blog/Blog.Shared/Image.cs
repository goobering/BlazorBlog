using System;

namespace Blog.Shared
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}