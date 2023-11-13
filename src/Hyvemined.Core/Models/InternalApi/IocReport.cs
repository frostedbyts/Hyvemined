using Hyvemined.Core.Models.Enums;
using Hyvemined.Core.Models.ExternalFeed;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IocReport
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
        public List<IocReportField> ExtractedFields { get; set; } = new List<IocReportField>();
        [JsonPropertyName("computed_fields")]
        public List<IocReportField> ComputedFields { get; set; } = new List<IocReportField>();
        [JsonPropertyName("user_defined_fields")]
        public List<IocReportField> UserDefinedFields { get; set; } = new List<IocReportField>();
        [JsonPropertyName("include_comments")]
        public bool IncludeComments { get; set; } = false;
        [JsonPropertyName("comments")]
        public List<UserComment>? Comments { get; set; }
        [JsonPropertyName("include_changelog")]
        public bool IncludeChangelog { get; set; }
        [JsonPropertyName("changelog")]
        public List<ChangelogEntry>? Changelog { get; set; }
        [JsonPropertyName("include_raw_report")]
        public bool IncludeRawReport { get; set; }
        [JsonPropertyName("raw_report")]
        public Dictionary<string, JsonElement>? RawReport { get; set; }


        public IocReport()
        {
            ReportId = Guid.NewGuid();
        }
    }
}
