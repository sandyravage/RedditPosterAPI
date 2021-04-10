using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LaterCloneAPI.Models
{
    public class SubredditResponse
    {
        [JsonPropertyName("createdDateUTC")]
        public float CreatedDateUTC { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("upvotes")]
        public long Upvotes { get; set; }
    }
}
