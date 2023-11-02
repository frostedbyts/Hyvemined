using Hyvemined.Core.Models.Enums;
using System.Net;
namespace Hyvemined.Core.Models.InternalApi.Responses
{
    public abstract class ApiResponse<T>
    {
        public bool Success { get; set; }

        public T? Data { get; set; }

        public string? Message { get; set; }

        public HttpStatusCode HttpStatus { get; set; }
    }
}
