using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Models.InternalApi
{
    public class IntelligenceCorrelationAction
    {
        [JsonPropertyName("action_type")]
        public CorrelationActionType ActionType { get; set; }
        [JsonPropertyName("target")]
        public string? Target { get; set; }
        [JsonPropertyName("input")]
        public string? Input { get; set; }
        [JsonPropertyName("output")]
        public string? Output { get; set; }
    }
}
