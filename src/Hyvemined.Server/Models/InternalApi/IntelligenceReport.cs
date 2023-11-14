using System.Text.Json;
using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Models.InternalApi
{
    public class IntelligenceReport
    {
        [JsonPropertyName("report_id")]
        [JsonPropertyOrder(order: -4)]
        public Guid ReportId { get; set; }
        [JsonPropertyName("friendly_report_id")]
        [JsonPropertyOrder(order: -3)]
        public string FriendlyReportId { get; set; } = string.Empty;
        [JsonPropertyName("feed")]
        [JsonPropertyOrder(order: -5)]
        public string Feed { get; set; } = string.Empty;
        [JsonPropertyName("ioc")]
        [JsonPropertyOrder(order: -7)]
        public string Ioc { get; set; } = string.Empty;
        [JsonPropertyName("ioc_type")]
        [JsonPropertyOrder(order: -6)]
        public IocType IocType { get; set; }
        [JsonPropertyName("report_type")]
        [JsonPropertyOrder(order: -2)]
        public ReportType ReportType { get; set; } = ReportType.Api;
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
        [JsonPropertyName("update_delta")]
        public TimeSpan UpdateDelta => DateTimeOffset.UtcNow - LastUpdated;
        [JsonPropertyName("extracted_fields")]
        public List<IntelligenceReportField> ExtractedFields { get; set; } = new List<IntelligenceReportField>();
        [JsonPropertyName("computed_fields")]
        public List<IntelligenceReportField> ComputedFields { get; set; } = new List<IntelligenceReportField>();
        [JsonPropertyName("user_defined_fields")]
        public List<IntelligenceReportField> UserDefinedFields { get; set; } = new List<IntelligenceReportField>();
        [JsonPropertyName("include_comments")]
        public bool IncludeComments { get; set; } = false;
        [JsonPropertyName("comments")]
        public List<UserComment>? Comments { get; set; }
        [JsonPropertyName("include_changelog")]
        public bool IncludeChangelog { get; set; } = false;
        [JsonPropertyName("changelog")]
        public List<ChangelogEntry>? Changelog { get; set; }
        [JsonPropertyName("include_raw_report")]
        public bool IncludeRawReport { get; set; }
        [JsonPropertyName("raw_report")]
        public Dictionary<string, JsonElement>? RawReport { get; set; }


        public IntelligenceReport()
        {
            ReportId = Guid.NewGuid();
        }
    }
}
