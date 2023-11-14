using System.Text.Json.Serialization;
using Hyvemined.CorrelationEngine.Models.Enums;

namespace Hyvemined.CorrelationEngine.Models.Results
{
    public class CorrelationAction
    {
        [JsonPropertyName("action_type")]
        public CorrelationActionType ActionType { get; set; }
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        [JsonPropertyName("target")]
        public string? Target { get; set; }
        [JsonPropertyName("old_value")]
        public string? OldValue { get; set; }
        [JsonPropertyName("new_value")]
        public string? NewValue { get; set; }
        [JsonPropertyName("input")]
        public string? Input { get; set; }
        [JsonPropertyName("output")]
        public string? Output { get; set; }
    }
}
