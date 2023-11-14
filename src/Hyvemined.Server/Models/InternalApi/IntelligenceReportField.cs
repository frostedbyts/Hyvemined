using System.Text.Json.Serialization;

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
