using System.Text.Json.Serialization;

namespace Hyvemined.Core.Models.InternalApi
{
    public class ChangelogEntry
    {
        [JsonPropertyName("changelog_entry_id")]
        public Guid ChangelogEntryId { get; set; }
        [JsonPropertyName("friendly_changelog_entry_id")]
        public string FriendlyChangelogEntryId { get; set; } = string.Empty;
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
        [JsonPropertyName("changed")]
        public string Changed { get; set; } = string.Empty;
        [JsonPropertyName("old_value")]
        public string OldValue { get; set; } = string.Empty;
        [JsonPropertyName("new_value")]
        public string NewValue { get; set; } = string.Empty;
        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        public ChangelogEntry()
        {
            ChangelogEntryId = Guid.NewGuid();
        }
    }
}
