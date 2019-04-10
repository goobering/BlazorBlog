// Sourced from: https://blog.jonblankenship.com/2019/01/27/safely-rendering-markdown-in-blazor/

using Ganss.XSS;
using Markdig;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blog.Client.Shared
{
    public class MarkdownViewModel : BlazorComponent
    {
        private string _content;

        [Inject]
        public IHtmlSanitizer HtmlSanitizer { get; set; }

        [Parameter]
        protected string Content
        {
            get => _content;
            set
            {
                _content = value;
                HtmlContent = ConvertStringToMarkupString(_content);
            }
        }

        public MarkupString HtmlContent { get; private set; }

        private MarkupString ConvertStringToMarkupString(string value)
        {
            if(!string.IsNullOrWhiteSpace(_content))
            {
                // Convert markdown string to HTML
                var html = Markdig.Markdown.ToHtml(value, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build());

                // Sanitize HTML before rendering
                var sanitizedHtml = HtmlSanitizer.Sanitize(html);

                // Return sanitized HTML as a MarkupString that Blazor can render
                return new MarkupString(sanitizedHtml);
            }

            return new MarkupString();
        }
    }
}