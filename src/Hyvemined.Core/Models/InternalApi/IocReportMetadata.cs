using System.Text.Json.Serialization;
using Hyvemined.Core.Models.Enums;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IocReportMetadata
    {
        [JsonPropertyName("feed")]
        public string Feed { get; set; } = string.Empty;
        [JsonPropertyName("report_id")]
        public Guid ReportId { get; set; }
        [JsonPropertyName("report_types")]
        public ReportType ReportType { get; set; }
        [JsonPropertyName("creadted")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

    }
}
