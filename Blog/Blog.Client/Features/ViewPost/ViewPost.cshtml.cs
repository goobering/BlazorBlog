using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blog.Shared;
using Markdig;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blog.Client.Features.ViewPost
{
    public class ViewPostModel : BlazorComponent
    {
        [Inject] 
        private HttpClient _httpClient { get; set; }

        [Parameter]
        protected string PostId { get; set; }

        protected BlogPost BlogPost { get; set; } = new BlogPost{Id=-1, Title=string.Empty, Author=string.Empty, Post=string.Empty, Posted=DateTime.Now, ImageUrl=string.Empty};

        protected override async Task OnInitAsync()
        {
            await LoadBlogPost();
        }

        private async Task LoadBlogPost()
        {
            BlogPost = await _httpClient.GetJsonAsync<BlogPost>(Urls.BlogPost.Replace("{id}", PostId));
        }
    }
}