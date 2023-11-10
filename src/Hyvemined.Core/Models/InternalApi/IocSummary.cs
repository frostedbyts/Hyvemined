using System.Text.Json.Serialization;
using Hyvemined.Core.Models.Enums;

namespace Hyvemined.Core.Models.InternalApi
{
    public class IocSummary
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
        public RiskSeverity Severity { get; set; } = RiskSeverity.None;
        [JsonPropertyName("linked_reports")]
        public List<IocReportMetadata>? LinkedReports { get; set; } 
        [JsonPropertyName("linked_correlations")]
        public List<IocCorrelationMetadata>? LinkedCorrelations { get; set; }

        public IocSummary()
        {
            SummaryId = Guid.NewGuid();
        }
    }
}
