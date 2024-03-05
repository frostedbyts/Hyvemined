using System.Text.Json.Serialization;
using Hyvemined.Server.Models.Enums.Jobs;

namespace Hyvemined.Server.Models.InternalApi
{
    public class JobData
    {
        [JsonPropertyName("job_id")]
        public Guid JobId { get; set; }
        [JsonPropertyName("friendly_job_id")]
        public string? FriendlyJobId { get; set; }
        [JsonPropertyName("state")]
        public JobState State { get; set; }
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; set; }
        [JsonPropertyName("started")]
        public DateTimeOffset Started { get; set; }
        [JsonPropertyName("completed")]
        public DateTimeOffset Completed { get; set; }
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        [JsonPropertyName("result_id")]
        public Guid? ResultId { get; set; }
        [JsonPropertyName("command")]
        public string? Command { get; set; }
        [JsonPropertyName("arguments")]
        public string? Arguments { get; set; }
    }
}
