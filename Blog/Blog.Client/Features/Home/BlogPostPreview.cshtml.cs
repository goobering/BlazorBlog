using Blog.Shared;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blog.Client.Features.Home
{
    public class BlogPostPreviewModel : BlazorComponent
    {
        [Parameter]
        protected BlogPost blogPost { get; set; }
    }

}