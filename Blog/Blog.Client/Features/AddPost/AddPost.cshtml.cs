using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Blog.Shared;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.JSInterop;

namespace Blog.Client.Features.AddPost
{
    public class AddPostModel : BlazorComponent
    {
        [Inject]
        private HttpClient _httpClient { get; set; }

        [Inject]
        private IUriHelper _uriHelper { get; set; }

        [Inject]
        private IJSRuntime JsRuntime { get; set; }
        
        protected ElementRef fileUpload;
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
            try
            {
                foreach(var img in Directory.EnumerateFiles(Path.Combine(Directory.GetCurrentDirectory(), "img"), "*.webp", SearchOption.TopDirectoryOnly))
                {
                    imgList.Add(img);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected async Task UploadFile()
        {
            var data = await JsRuntime.InvokeAsync<string>("fileReaderFunctions.readUploadedFileAsText", fileUpload);
            var response = await _httpClient.PostAsync(Urls.UploadFile, new ByteArrayContent(Convert.FromBase64String(data)));
            var fileTempName = await response.Content.ReadAsStringAsync();
        }
    }
}