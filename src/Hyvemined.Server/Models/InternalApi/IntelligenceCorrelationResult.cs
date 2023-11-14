using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Models.InternalApi
{
    public class IntelligenceCorrelationResult
    {
        [JsonPropertyName("correlation_result_id")]
        public Guid CorrelationResultId { get; set; }
        [JsonPropertyName("correlation_name")]
        public string CorrelationName { get; set; } = string.Empty;
        [JsonPropertyName("matched")]
        public bool Matched { get; set; }
        [JsonPropertyName("assigned_score")]
        public int AssignedScore { get; set; }
        [JsonPropertyName("assigned_risk")]
        public ThreatSeverity AssignedRisk { get; set; }
        [JsonPropertyName("assigned_tags")]
        public List<string>? AssignedTags { get; set; }
        [JsonPropertyName("actions")]
        public List<IntelligenceCorrelationAction>? Actions { get; set; }
    }
}
