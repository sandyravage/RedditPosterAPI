using LaterCloneAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LaterCloneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedditController : ControllerBase
    {
        private IRedditOrchestrator _redditOrchestrator;
        public RedditController(IRedditOrchestrator redditOrchestrator)
        {
            _redditOrchestrator = redditOrchestrator;
        }

        [HttpGet("getposts/{subreddit}")]
        public async Task<IActionResult> GetPosts(string subreddit, [FromQuery] string t)
        {
            if(string.IsNullOrWhiteSpace(subreddit))
            {
                return BadRequest("Must provide subreddit");
            }
            var response = await _redditOrchestrator.GetTopPosts(subreddit, t);
            return Ok(response);
        }        
    }
}
