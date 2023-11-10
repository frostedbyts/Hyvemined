using System.Text.Json.Serialization;

namespace Hyvemined.Core.Models.InternalApi
{
    public class UserComment
    {
        [JsonPropertyName("comment_id")]
        public Guid CommentId { get; set; }
        [JsonPropertyName("friendly_comment_id")]
        public string FriendlyCommentId { get; set; } = string.Empty;
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("updated")]
        public DateTimeOffset Updated { get; set; }
    }
}
