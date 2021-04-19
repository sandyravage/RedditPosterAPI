using LaterCloneAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaterCloneAPI.Interfaces
{
    public interface IRedditOrchestrator
    {
        //Task<string> GetRedditPosts();
        Task<IEnumerable<SubredditResponse>> GetTopPosts(string subreddit, string t);
    }
}
