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

        public async Task<IEnumerable<SubredditResponse>> GetTopPosts(string subreddit, string t)
        {
            var subredditResponses = new List<SubredditResponse>();
            string after = "";
            var period = !string.IsNullOrWhiteSpace(t) ? t : "week";
            for (var count = 0; count <= 1000; count += 100)
            {
                var request = new HttpRequestMessage();
                var uri = count == 0 ? $"r/{subreddit}/top.json?t={period}&limit=100" : $"r/{subreddit}/top.json?t={period}&limit=100&count={count}&after={after}";
                var requestUri = new Uri(uri, UriKind.Relative);
                request.RequestUri = requestUri;
                request.Method = HttpMethod.Get;
                var response = await _httpClient.SendAsync(request);
                var payload = await response.Content.ReadAsStringAsync();
                var parsedResponse = JsonSerializer.Deserialize<SubredditQueryResponse>(payload);
                BuildResponse(subredditResponses, parsedResponse);
                if (!string.IsNullOrWhiteSpace(parsedResponse.Data.After))
                {
                    after = parsedResponse.Data.After;
                }
                else
                {
                    break;
                }                
            }

            return subredditResponses;
        }

        private void BuildResponse(List<SubredditResponse> subredditResponses, SubredditQueryResponse response)
        {
            foreach(var post in response.Data.Children)
            {
                subredditResponses.Add(new SubredditResponse { 
                    CreatedDateUTC = post.Data.CreatedUtc,
                    Title = post.Data.Title,
                    Upvotes = post.Data.Ups
                });
            }
        }
    }
}
