using System.IO;
using System.Threading.Tasks;
using Blog.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Server.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost(Urls.UploadFile)]
        public async Task<IActionResult> Save()
        {
            var tempFileName = Path.GetTempFileName();
            using(var writer = System.IO.File.OpenWrite(tempFileName))
            {
                await Request.Body.CopyToAsync(writer);
            }
            return Ok(new FileUploadResult { TempFileName = Path.GetFileNameWithoutExtension(tempFileName) });
        }
    }
}