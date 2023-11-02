using Hyvemined.Core.Models.Enums;
using Hyvemined.Core.Models.ExternalFeed;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IocReport<T> where T : IExternalIocReport
    {
        [JsonPropertyName("report_id")]
        public Guid ReportId { get; set; }
        [JsonPropertyName("feed")]
        public string Feed { get; set; } = string.Empty;
        [JsonPropertyName("ioc")]
        public string Ioc { get; set; } = string.Empty;
        [JsonPropertyName("ioc_type")]
        public IocType IocType { get; set; }
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
        [JsonPropertyName("raw_report")]
        public IExternalIocReport? RawReport { get; set; }

        public IocReport()
        {
            ReportId = Guid.NewGuid();
        }
    }
}
