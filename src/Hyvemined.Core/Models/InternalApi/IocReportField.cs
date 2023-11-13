using System.Text.Json.Serialization;
using Hyvemined.Core.Models.Enums;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IocReportField
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        [JsonPropertyName("field_type")]
        public ReportFieldType FieldType { get; set; }
    }
}
