using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;

namespace Blog.Client.Shared
{
    public class FileUploaderModel : BlazorComponent
    {
        protected ElementRef fileUpload;

        [Inject]
        private HttpClient _httpClient { get; set; }

        [Inject]
        private IJSRuntime _jsRuntime { get; set; }

        [Parameter]
        protected string Url { get; set; }
        
        protected async Task UploadFile()
        {
            var data = await _jsRuntime.InvokeAsync<string>("fileReaderFunctions.readUploadedFileAsText", fileUpload);
            var response = await _httpClient.PostAsync(Url, new ByteArrayContent(Convert.FromBase64String(data)));
            // var fileTempName = await response.Content.ReadAsStringAsync();
        }
    }
}