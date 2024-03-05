using System.Net;
using System.Text.Json.Serialization;

namespace Hyvemined.Server.Models.InternalApi.Responses
{
    public abstract class ApiResponse<T>
    {
        [JsonPropertyName("succeeded")]
        public bool Succeeded { get; set; }
        [JsonPropertyName("http_status")]
        public HttpStatusCode HttpStatus { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("data")]
        public T? Data { get; set; }
    }
}
