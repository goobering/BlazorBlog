using Microsoft.AspNetCore.Mvc;
using Blog.Shared;

namespace Blog.Server.Controllers
{
    public class BlogPostsController : Controller
    {
        private readonly IDataRepository<BlogPost> _dataRepository;

        public BlogPostsController(IDataRepository<BlogPost> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        
        [HttpGet(Urls.BlogPosts)]
        public IActionResult GetBlogPosts()
        {
            return Ok(_dataRepository.GetAll());
        }

        [HttpGet(Urls.BlogPost, Name = "GetPostById")]
        public IActionResult GetBlogPost(int id)
        {
            var post = _dataRepository.Get(id);

            if(post == null)
            {
                return NotFound("No post exists with that ID.");
            }

            return Ok(post);
        }

        [HttpPost(Urls.AddBlogPost)]
        public IActionResult AddBlogPost([FromBody]BlogPost newBlogPost)
        {
            if(newBlogPost == null)
            {
                return BadRequest("New post is null.");
            }

            _dataRepository.Add(newBlogPost);
            return CreatedAtRoute(
                "GetPostById",
                new { Id = newBlogPost.Id },
                newBlogPost);
        }

        [HttpPut(Urls.UpdateBlogPost)]
        public IActionResult UpdateBlogPost(int id, [FromBody]BlogPost updatedBlogPost)
        {
            if(updatedBlogPost == null)
            {
                return BadRequest("Updated post is null.");
            }

            BlogPost postToUpdate = _dataRepository.Get(id);
            if(postToUpdate == null)
            {
                return NotFound("The blog post you're trying to update couldn't be found.");
            }

            _dataRepository.Update(postToUpdate, updatedBlogPost);
            return Ok();
        }

        [HttpDelete(Urls.DeleteBlogPost)]
        public IActionResult DeleteBlogPost(int id)
        {
            BlogPost post = _dataRepository.Get(id);
            if(post == null)
            {
                return NotFound("The post couldn't be found.");
            }

            _dataRepository.Delete(post);
            return Ok();
        }
    }
}