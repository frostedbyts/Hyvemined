using Hyvemined.Core.Models.Enums;
using System.Net;
using System.Text.Json.Serialization;
namespace Hyvemined.Core.Models.InternalApi.Responses
{
    public abstract class ApiResponse<T>
    {
        [JsonPropertyName("success")]
        [JsonPropertyOrder(-4)]
        public bool Success { get; set; }
        [JsonPropertyName("data")]
        [JsonPropertyOrder(-1)]
        public T? Data { get; set; }
        [JsonPropertyName("message")]
        [JsonPropertyOrder(-2)]
        public string? Message { get; set; }
        [JsonPropertyName("http_status")]
        [JsonPropertyOrder(-3)]
        public HttpStatusCode HttpStatus { get; set; }
    }
}
