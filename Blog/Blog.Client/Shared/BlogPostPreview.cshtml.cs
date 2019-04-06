using Blog.Shared;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blog.Client.Shared
{
    public class BlogPostPreviewModel : BlazorComponent
    {
        [Parameter]
        protected BlogPost BlogPost { get; set; }
    }
}