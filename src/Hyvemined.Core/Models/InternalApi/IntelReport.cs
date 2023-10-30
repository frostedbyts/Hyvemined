using Hyvemined.Core.Models.Enums;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IntelReport
    {
        public Guid ReportId { get; set; }

        public string? Feed { get; set; }

        public string? Ioc { get; set; }

        public IocType Type { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public TimeSpan UpdateDelta => DateTimeOffset.UtcNow - LastUpdated;
    }
}
