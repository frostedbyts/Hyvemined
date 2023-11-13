using System.Text.Json.Serialization;
using Hyvemined.Core.Models.Enums;

namespace Hyvemined.Core.Models.InternalApi
{
    public class IocCorrelationResult
    {
        [JsonPropertyName("correlation_result_id")]
        public Guid CorrelationResultId { get; set; }
        [JsonPropertyName("correlation_name")]
        public string CorrelationName { get; set; } = string.Empty;
        [JsonPropertyName("correlation_config_id")]
        public Guid CorrelationConfigId { get; set; }
        [JsonPropertyName("correlation_type")]
        public CorrelationType CorrelationType { get; set; }
        [JsonPropertyName("ioc")]
        public string Ioc { get; set; } = string.Empty;
        [JsonPropertyName("matched")]
        public bool Matched { get; set; }
        [JsonPropertyName("assigned_score")]
        public int AssignedScore { get; set; }
        [JsonPropertyName("assigned_risk")]
        public RiskSeverity AssignedRisk { get; set; }
        [JsonPropertyName("assigned_tags")]
        public List<string>? AssignedTags { get; set; }
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("updated")]
        public DateTimeOffset Updated { get; set; }
        [JsonPropertyName("correlation_created")]
        public DateTimeOffset CorrelationCreated { get; set; }
        [JsonPropertyName("correlation_updated")]
        public DateTimeOffset CorrelationUpdated { get; set; }
        [JsonPropertyName("first_run")]
        public DateTimeOffset FirstRun { get; set; }
        [JsonPropertyName("last_run")]
        public DateTimeOffset LastRun { get; set; }
        [JsonPropertyName("actions")]
        public List<IocCorrelationResultAction>? Actions { get; set; }

        public IocCorrelationResult()
        {
            CorrelationResultId = Guid.NewGuid();
        }
    }
}
