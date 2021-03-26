
using System.Text.Json.Serialization;
using System;

namespace LaterCloneAPI.Models
{
    public partial class SubredditQueryResponse
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("data")]
        public SubredditQueryResponseData Data { get; set; }
    }

    public partial class SubredditQueryResponseData
    {
        [JsonPropertyName("modhash")]
        public string Modhash { get; set; }

        [JsonPropertyName("dist")]
        public long Dist { get; set; }

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
        [JsonPropertyName("approved_at_utc")]
        public object ApprovedAtUtc { get; set; }

        [JsonPropertyName("subreddit")]
        public string Subreddit { get; set; }

        [JsonPropertyName("selftext")]
        public string Selftext { get; set; }

        [JsonPropertyName("author_fullname")]
        public string AuthorFullname { get; set; }

        [JsonPropertyName("saved")]
        public bool Saved { get; set; }

        [JsonPropertyName("mod_reason_title")]
        public object ModReasonTitle { get; set; }

        [JsonPropertyName("gilded")]
        public long Gilded { get; set; }

        [JsonPropertyName("clicked")]
        public bool Clicked { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link_flair_richtext")]
        public object[] LinkFlairRichtext { get; set; }

        [JsonPropertyName("subreddit_name_prefixed")]
        public string SubredditNamePrefixed { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }

        [JsonPropertyName("pwls")]
        public object Pwls { get; set; }

        [JsonPropertyName("link_flair_css_class")]
        public object LinkFlairCssClass { get; set; }

        [JsonPropertyName("downs")]
        public long Downs { get; set; }

        [JsonPropertyName("thumbnail_height")]
        public object ThumbnailHeight { get; set; }

        [JsonPropertyName("top_awarded_type")]
        public object TopAwardedType { get; set; }

        [JsonPropertyName("hide_score")]
        public bool HideScore { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quarantine")]
        public bool Quarantine { get; set; }

        [JsonPropertyName("link_flair_text_color")]
        public string LinkFlairTextColor { get; set; }

        [JsonPropertyName("upvote_ratio")]
        public double UpvoteRatio { get; set; }

        [JsonPropertyName("author_flair_background_color")]
        public object AuthorFlairBackgroundColor { get; set; }

        [JsonPropertyName("subreddit_type")]
        public string SubredditType { get; set; }

        [JsonPropertyName("ups")]
        public long Ups { get; set; }

        [JsonPropertyName("total_awards_received")]
        public long TotalAwardsReceived { get; set; }

        [JsonPropertyName("media_embed")]
        public Gildings MediaEmbed { get; set; }

        [JsonPropertyName("thumbnail_width")]
        public object ThumbnailWidth { get; set; }

        [JsonPropertyName("author_flair_template_id")]
        public object AuthorFlairTemplateId { get; set; }

        [JsonPropertyName("is_original_content")]
        public bool IsOriginalContent { get; set; }

        [JsonPropertyName("user_reports")]
        public object[] UserReports { get; set; }

        [JsonPropertyName("is_reddit_media_domain")]
        public bool IsRedditMediaDomain { get; set; }

        [JsonPropertyName("is_meta")]
        public bool IsMeta { get; set; }

        [JsonPropertyName("category")]
        public object Category { get; set; }

        [JsonPropertyName("link_flair_text")]
        public object LinkFlairText { get; set; }

        [JsonPropertyName("can_mod_post")]
        public bool CanModPost { get; set; }

        [JsonPropertyName("score")]
        public long Score { get; set; }

        [JsonPropertyName("approved_by")]
        public object ApprovedBy { get; set; }

        [JsonPropertyName("author_premium")]
        public bool AuthorPremium { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("edited")]
        public bool Edited { get; set; }

        [JsonPropertyName("author_flair_css_class")]
        public object AuthorFlairCssClass { get; set; }

        [JsonPropertyName("author_flair_richtext")]
        public object[] AuthorFlairRichtext { get; set; }

        [JsonPropertyName("gildings")]
        public Gildings Gildings { get; set; }

        [JsonPropertyName("content_categories")]
        public object ContentCategories { get; set; }

        [JsonPropertyName("is_self")]
        public bool IsSelf { get; set; }

        [JsonPropertyName("mod_note")]
        public object ModNote { get; set; }

        [JsonPropertyName("created")]
        public float Created { get; set; }

        [JsonPropertyName("link_flair_type")]
        public string LinkFlairType { get; set; }

        [JsonPropertyName("wls")]
        public object Wls { get; set; }

        [JsonPropertyName("removed_by_category")]
        public object RemovedByCategory { get; set; }

        [JsonPropertyName("banned_by")]
        public object BannedBy { get; set; }

        [JsonPropertyName("author_flair_type")]
        public string AuthorFlairType { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("allow_live_comments")]
        public bool AllowLiveComments { get; set; }

        [JsonPropertyName("selftext_html")]
        public string SelftextHtml { get; set; }

        [JsonPropertyName("likes")]
        public object Likes { get; set; }

        [JsonPropertyName("suggested_sort")]
        public object SuggestedSort { get; set; }

        [JsonPropertyName("banned_at_utc")]
        public object BannedAtUtc { get; set; }

        [JsonPropertyName("view_count")]
        public object ViewCount { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("no_follow")]
        public bool NoFollow { get; set; }

        [JsonPropertyName("is_crosspostable")]
        public bool IsCrosspostable { get; set; }

        [JsonPropertyName("pinned")]
        public bool Pinned { get; set; }

        [JsonPropertyName("over_18")]
        public bool Over18 { get; set; }

        [JsonPropertyName("all_awardings")]
        public object[] AllAwardings { get; set; }

        [JsonPropertyName("awarders")]
        public object[] Awarders { get; set; }

        [JsonPropertyName("media_only")]
        public bool MediaOnly { get; set; }

        [JsonPropertyName("can_gild")]
        public bool CanGild { get; set; }

        [JsonPropertyName("spoiler")]
        public bool Spoiler { get; set; }

        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        [JsonPropertyName("author_flair_text")]
        public object AuthorFlairText { get; set; }

        [JsonPropertyName("treatment_tags")]
        public object[] TreatmentTags { get; set; }

        [JsonPropertyName("visited")]
        public bool Visited { get; set; }

        [JsonPropertyName("removed_by")]
        public object RemovedBy { get; set; }

        [JsonPropertyName("num_reports")]
        public object NumReports { get; set; }

        [JsonPropertyName("distinguished")]
        public object Distinguished { get; set; }

        [JsonPropertyName("subreddit_id")]
        public string SubredditId { get; set; }

        [JsonPropertyName("mod_reason_by")]
        public object ModReasonBy { get; set; }

        [JsonPropertyName("removal_reason")]
        public object RemovalReason { get; set; }

        [JsonPropertyName("link_flair_background_color")]
        public string LinkFlairBackgroundColor { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("is_robot_indexable")]
        public bool IsRobotIndexable { get; set; }

        [JsonPropertyName("report_reasons")]
        public object ReportReasons { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("discussion_type")]
        public object DiscussionType { get; set; }

        [JsonPropertyName("num_comments")]
        public long NumComments { get; set; }

        [JsonPropertyName("send_replies")]
        public bool SendReplies { get; set; }

        [JsonPropertyName("whitelist_status")]
        public object WhitelistStatus { get; set; }

        [JsonPropertyName("contest_mode")]
        public bool ContestMode { get; set; }

        [JsonPropertyName("mod_reports")]
        public object[] ModReports { get; set; }

        [JsonPropertyName("author_patreon_flair")]
        public bool AuthorPatreonFlair { get; set; }

        [JsonPropertyName("author_flair_text_color")]
        public object AuthorFlairTextColor { get; set; }

        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        [JsonPropertyName("parent_whitelist_status")]
        public object ParentWhitelistStatus { get; set; }

        [JsonPropertyName("stickied")]
        public bool Stickied { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("subreddit_subscribers")]
        public long SubredditSubscribers { get; set; }

        [JsonPropertyName("created_utc")]
        public float CreatedUtc { get; set; }

        [JsonPropertyName("num_crossposts")]
        public long NumCrossposts { get; set; }

        [JsonPropertyName("media")]
        public object Media { get; set; }

        [JsonPropertyName("is_video")]
        public bool IsVideo { get; set; }
    }

    public partial class Gildings
    {
    }
}
