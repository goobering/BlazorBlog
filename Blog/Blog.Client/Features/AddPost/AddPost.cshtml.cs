using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blog.Shared;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Services;

namespace Blog.Client.Features.AddPost
{
    public class AddPostModel : BlazorComponent
    {
        [Inject]
        private HttpClient _httpClient { get; set; }

        [Inject]
        private IUriHelper _uriHelper { get; set; }
        protected string Post { get; set; }
        protected string Title { get; set; }
        protected string UploadUrl { get; set; } = Urls.UploadFile;

        public async Task SavePost()
        {
            var newPost = new BlogPost()
            {
                Title = Title,
                Author = "Joe Bloggs",
                Post = Post,
                Posted = DateTime.Now,
                ImageUrl = string.Empty
            };

            var savedPost = await _httpClient.PostJsonAsync<BlogPost>(Urls.AddBlogPost, newPost);

            _uriHelper.NavigateTo($"viewpost/{savedPost.Id}");
        }
    }
}