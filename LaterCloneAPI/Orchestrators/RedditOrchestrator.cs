using LaterCloneAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LaterCloneAPI.Models;
using System.Text.Json;
using System.Linq;

namespace LaterCloneAPI.Orchestrators
{
    public class RedditOrchestrator : IRedditOrchestrator
    {
        private readonly HttpClient _httpClient;
        public RedditOrchestrator(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetRedditPosts()
        {
            var clientId = "";
            var clientSecret = "";
            var authString = $"{clientId}:{clientSecret}";
            var authStringBytes = System.Text.Encoding.UTF8.GetBytes(authString);
            var encodedString = Convert.ToBase64String(authStringBytes);
            var requestUri = new Uri("api/v1/access_token", UriKind.Relative);
            var content = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("grant_type", "client_credentials") });
            var request = new HttpRequestMessage();
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", encodedString);
            request.Content = content;
            request.RequestUri = requestUri;
            request.Method = HttpMethod.Post;
            var response = await _httpClient.SendAsync(request);
            var payload = await response.Content.ReadAsStringAsync();
            var parsedResponse = JsonSerializer.Deserialize<RedditAuth0Response>(payload);
            var secondRequest = new HttpRequestMessage();
            var context = 2;
            var user = "tenthousandhands";
            var after = "t1_da24p27";
            var before = "t1_da5rawj";
            var count = 10;
            var secondRequestUri = new Uri($"https://oauth.reddit.com/user/{user}/comments?context={context}&show=given&sort=top&t=all&type=comments&username={user}&after={after}&before={before}&count={count}&limit=100");
            secondRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", parsedResponse.AccessToken);
            secondRequest.Headers.Add("User-Agent", "bigolelongteststring123");
            secondRequest.Method = HttpMethod.Get;
            secondRequest.RequestUri = secondRequestUri;
            var secondResponse = await _httpClient.SendAsync(secondRequest);
            return await secondResponse.Content.ReadAsStringAsync();
        }

        public async Task<IEnumerable<SubredditResponse>> GetTopPosts(string subreddit)
        {
            var request = new HttpRequestMessage();
            var requestUri = new Uri($"r/{subreddit}/top.json?t=week", UriKind.Relative);
            request.RequestUri = requestUri;
            request.Method = HttpMethod.Get;
            var response = await _httpClient.SendAsync(request);
            var payload = await response.Content.ReadAsStringAsync();
            var parsedResponse = JsonSerializer.Deserialize<SubredditQueryResponse>(payload);
            return BuildResponse(parsedResponse);
        }

        private IEnumerable<SubredditResponse> BuildResponse(SubredditQueryResponse response)
        {
            var subredditResponses = new List<SubredditResponse>();
            foreach(var post in response.Data.Children)
            {
                subredditResponses.Add(new SubredditResponse { 
                    CreatedDateUTC = post.Data.CreatedUtc,
                    Title = post.Data.Title,
                    Upvotes = post.Data.Ups
                });
            }
            return subredditResponses;
        }
    }
}
