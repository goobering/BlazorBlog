using System;
using System.Collections.Generic;
using System.IO;
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
        protected List<string> imgList { get; set; } = new List<string>();

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

        protected override async Task OnInitAsync()
        {
            await LoadImages();
        }

        private async Task LoadImages()
        {
            string sourceDir = @"./wwwroot/img";

            try
            {
                foreach(var img in Directory.EnumerateFiles(sourceDir, "*.webp", SearchOption.TopDirectoryOnly))
                {
                    imgList.Add(img);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}