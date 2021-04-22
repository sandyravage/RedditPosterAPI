
using System.Text.Json.Serialization;
using System;

namespace LaterCloneAPI.Models
{
    public partial class SubredditQueryResponse
    {

        [JsonPropertyName("data")]
        public SubredditQueryResponseData Data { get; set; }
    }

    public partial class SubredditQueryResponseData
    {
        [JsonPropertyName("children")]
        public Child[] Children { get; set; }

        [JsonPropertyName("after")]
        public string After { get; set; }

        [JsonPropertyName("before")]
        public string Before { get; set; }
    }

    public partial class Child
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("data")]
        public ChildData Data { get; set; }
    }

    public partial class ChildData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("downs")]
        public long Downs { get; set; }

        [JsonPropertyName("ups")]
        public long Ups { get; set; }

        [JsonPropertyName("created_utc")]
        public float CreatedUtc { get; set; }
    }
}
