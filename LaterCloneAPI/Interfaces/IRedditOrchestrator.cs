using LaterCloneAPI.Models;
using System.Threading.Tasks;

namespace LaterCloneAPI.Interfaces
{
    public interface IRedditOrchestrator
    {
        //Task<string> GetRedditPosts();
        Task<SubredditQueryResponse> GetTopPosts(string subreddit);
    }
}
