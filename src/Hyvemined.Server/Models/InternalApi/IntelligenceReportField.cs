using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Models.InternalApi
{
    public class IntelligenceReportField
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        [JsonPropertyName("field_type")]
        public ReportFieldType FieldType { get; set; }
    }
}
