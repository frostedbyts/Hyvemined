using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Models.InternalApi
{
    public class IntelligenceSummary
    {
        [JsonPropertyName("ioc")]
        public string Ioc { get; set; } = string.Empty;
        [JsonPropertyName("ioc_type")]
        public IocType IocType { get; set; }
        [JsonPropertyName("summary_id")]
        public Guid SummaryId { get; set; }
        [JsonPropertyName("friendly_summary_id")]
        public string FriendlySummaryId { get; set; } = string.Empty;
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
        [JsonPropertyName("updated_delta")]
        public TimeSpan UpdateDelta => DateTimeOffset.UtcNow - LastUpdated;
        [JsonPropertyName("feeds")]
        public List<string> Feeds { get; set; } = new List<string>();
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; } 
        [JsonPropertyName("score")]
        public int Score { get; set; } = 0;
        [JsonPropertyName("severity")]
        public ThreatSeverity Severity { get; set; } = ThreatSeverity.None;
        [JsonPropertyName("linked_reports")]
        public List<IntelligenceReport>? LinkedReports { get; set; } 
        [JsonPropertyName("linked_correlations")]
        public List<IntelligenceCorrelationResult>? LinkedCorrelations { get; set; }
        [JsonPropertyName("include_comments")]
        public bool IncludeComments { get; set; } = false;
        [JsonPropertyName("comments")]
        public List<UserComment>? Comments { get; set; }
        [JsonPropertyName("include_changelog")]
        public bool IncludeChangelog { get; set; } = false;
        [JsonPropertyName("changelog")]
        public List<ChangelogEntry>? Changelog { get; set; }
        public IntelligenceSummary()
        {
            SummaryId = Guid.NewGuid();
        }
    }
}
